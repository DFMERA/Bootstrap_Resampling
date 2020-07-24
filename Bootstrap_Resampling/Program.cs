using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Microsoft.ML;

namespace Bootstrap_Resampling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MLContext mlContext = new MLContext();

            //Cargamos el dataset original
            string dataPath = GetAbsolutePath("../../../data/HotelBookingsRate.tsv");
            var data = mlContext.Data.LoadFromTextFile<ModelInput>(dataPath,
                                                    separatorChar: '\t', hasHeader: true);
            //Creamos dos remuestreos (bags)
            for (int i = 0; i < 2; i++)
            {
                //generamos el nuevo dataset usando Bootstrap
                var resample = mlContext.Data.BootstrapSample(data, seed: i);

                var enumerable = mlContext.Data
                    .CreateEnumerable<ModelInput>(resample, reuseRowObject: false);

                Console.WriteLine($"Print sample preview out of {enumerable.Count()}");
                PrintHeaders(typeof(ModelInput));

                //ver los datos del nuevo dataset
                //estos dataset los podemos usar para entrenar un modelo
                foreach (var row in enumerable.Take(10))
                {
                    PrintValues(row);
                }
                Console.WriteLine();
            }

            //Creamos un remuestreo y un dataset out-of-bag
            //Este dataset lo podemos usar para probar o evaluar un modelo
            var resampleOob = mlContext.Data.BootstrapSample(data, 1, complement: true);

            var enumerableOob = mlContext.Data
                    .CreateEnumerable<ModelInput>(resampleOob, reuseRowObject: false);

            Console.WriteLine($"Print sample preview out of {enumerableOob.Count()}");
            PrintHeaders(typeof(ModelInput));
            foreach (var row in enumerableOob.Take(10))
            {
                PrintValues(row);
            }

            Console.ReadLine();

        }

        public static string GetAbsolutePath(string relativePath)
        {
            FileInfo _dataRoot = new FileInfo(typeof(Program).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            char separatorChar = Path.VolumeSeparatorChar == ':' ? '\\' : '/';
            relativePath = relativePath.Replace('\\', separatorChar);

            string fullPath = Path.Combine(assemblyFolderPath, relativePath);

            return fullPath;
        }

        private static void PrintHeaders(Type type)
        {
            string headers = "";
            foreach (var header in type.GetProperties())
            {
                headers += header.Name + '\t';
            }
            Console.WriteLine(headers);
        }

        private static void PrintValues(ModelInput enumerable)
        {
            string rowValues = "";
            
            foreach (PropertyDescriptor row in TypeDescriptor.GetProperties(enumerable))
            {
                rowValues += row.GetValue(enumerable).ToString() + '\t';
            }
            Console.WriteLine(rowValues);
        }
    }
}
