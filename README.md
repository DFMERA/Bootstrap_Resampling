# Bootstrap_Resampling
En este proyecto usamos la técnica de bootstrap con ML.NET para generar nuevos dataset de entrenamiento y prueba
La descripción completa de este ejemplo aquí:
[Blog Acelera.Tech](https://acelera.tech/2020/07/24/machine-learning-como-generar-nuevos-datasets-usando-bootstrap-y-ml-net/)

Bootstrap es una técnica de remuestreo utilizada para estimar estadísticas de una población mediante el muestreo de un conjunto de datos con reemplazo. En palabras más simples; imaginemos que tenemos una muestra de datos en un dataset y queremos generar una nueva muestra de igual o menor tamaño, entonces tomamos un dato del dataset original de manera aleatoria y la colocamos en un nuevo dataset, a la vez que devolvemos el dato seleccionado al dataset original, y repetimos el proceso hasta generar la nueva muestra deseada. Este enfoque de muestreo se llama muestreo con reemplazo (sampling with replacement).
