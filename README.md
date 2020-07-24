# Machine Learning | Cómo generar nuevos datasets usando bootstrap y ML.NET
En este proyecto usamos la técnica de bootstrap con ML.NET para generar nuevos dataset de entrenamiento y prueba
La descripción completa de este ejemplo aquí:
[Blog Acelera.Tech](https://acelera.tech/2020/07/24/machine-learning-como-generar-nuevos-datasets-usando-bootstrap-y-ml-net/)

[Bootstrap](https://en.wikipedia.org/wiki/Bootstrapping_(statistics)) es una técnica de remuestreo utilizada para estimar estadísticas de una población mediante el muestreo de un conjunto de datos con reemplazo. En palabras más simples; imaginemos que tenemos una muestra de datos en un dataset y queremos generar una nueva muestra de igual o menor tamaño, entonces tomamos un dato del dataset original de manera aleatoria y la colocamos en un nuevo dataset, a la vez que devolvemos el dato seleccionado al dataset original, y repetimos el proceso hasta generar la nueva muestra deseada. Este enfoque de muestreo se llama muestreo con reemplazo (sampling with replacement).

Esta técnica de bootstrap puede ser muy útil en los siguientes casos.

Cuando se quiere mejorar la distribución de los datos. En el caso de [ML.NET](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet) la técnica de bootstrap utiliza una distribución de [Poisson(1)](https://en.wikipedia.org/wiki/Poisson_distribution) para generar el nuevo dataset.

Cuando se tiene un dataset muy pequeño y se necesitan más muestras. Ya que los nuevos dataset que genera el remuestreo con bootstrap tiene una valides estadística, estos se pueden usar para entrenar varios modelos con los nuevos dataset o inclusive combinarlos para generar un nuevo dataset con un mayor número de datos.

Para probar un modelo con los datos "fuera de la bolsa" (out-of-bag). Ya que un dato dentro de un dataset puede no ser seleccionado para formar parte del remuestreo, estos datos no seleccionados se los puede usar para generar un nuevo dataset llamado "out-of-bag¨" y usarlo como dataset de prueba para evaluar un modelo generado con un dataset de entrenamiento.
