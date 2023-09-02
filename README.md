
# OnionCrafter.Util.BinarySerialization

![Versión de la librería](https://img.shields.io/badge/Versi%C3%B3n-1.0.0-brightgreen) [![NuGet](https://img.shields.io/nuget/v/OnionCrafter.Utils.BinarySerialization.svg)](https://www.nuget.org/packages/OnionCrafter.Utils.BinarySerialization/)

![](https://raw.githubusercontent.com/Dtopiast/OnionCrafter.Util.BinarySerialization/main/Images/Logo.png)

**Estado de la Librería: Pre-Alfa - No Listo para Producción**

Esta librería se encuentra actualmente en un estado pre-alfa, lo que significa que está en una fase muy temprana de desarrollo y no está destinada para su uso en entornos de producción. Estamos trabajando arduamente para mejorar y estabilizar la librería, pero aún pueden existir errores y limitaciones significativas.

Si estás interesado en utilizar esta librería, te recomendamos encarecidamente que la pruebes en un entorno de desarrollo o pruebas para evaluar su idoneidad para tu proyecto. No se garantiza la estabilidad ni la compatibilidad con versiones futuras en este estado inicial.

Por favor, mantente atento a futuras actualizaciones y anuncios sobre el progreso de la librería. Tu retroalimentación y contribuciones son bienvenidas a medida que avanzamos hacia una versión más estable y lista para producción.

## Descripción

**OnionCrafter.Util.BinarySerialization** es una librería de utilidades de serialización binaria para .NET 7. Esta librería proporciona métodos sencillos para la serialización y deserialización de objetos en formato binario. Utiliza opciones de serialización JSON personalizables para garantizar una mayor flexibilidad.

## Características

- Serializa objetos a datos binarios.
- Deserializa datos binarios a objetos del tipo especificado.
- Opciones de serialización JSON personalizables.
- Fácil de usar y ligera.

## Requisitos

- .NET 7

## Instalación

Puedes agregar esta librería a tu proyecto .NET 7 a través de NuGet. Usa el siguiente comando de NuGet para instalarla:

```bash
dotnet add package OnionCrafter.Util.BinarySerialization
```

## Uso

Para utilizar esta librería en tu proyecto, simplemente sigue los ejemplos a continuación:

```csharp
// Serializar un objeto a datos binarios
var objetoSerializado = miObjeto.SerializeToBinary();

// Deserializar datos binarios a un objeto del tipo especificado
var objetoDeserializado = datosBinarios.DeserializeToObject<MiClase>();
```


## Contribuir

Si deseas contribuir a esta librería, ¡te damos la bienvenida! Puedes hacerlo de las siguientes maneras:

1. **Informa problemas:** Si encuentras algún problema o error, por favor, abre un [issue](https://github.com/dtopiast/OnionCrafter.Utils.Exception/issues).

2. **Envía Pull Requests:** Si deseas agregar nuevas características o corregir errores existentes, no dudes en enviar un [pull request](https://github.com/dtopiast/OnionCrafter.Utils.Exception/pulls).
## Licencia

Este proyecto está bajo la [Licencia Mozilla Public v. 2](LICENSE.txt). Consulta el archivo LICENSE.md para obtener más información.
