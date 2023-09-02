
# OnionCrafter.Util.BinarySerialization

![Versi�n de la librer�a](https://img.shields.io/badge/Versi%C3%B3n-1.0.0-brightgreen) [![NuGet](https://img.shields.io/nuget/v/OnionCrafter.Utils.BinarySerialization.svg)](https://www.nuget.org/packages/OnionCrafter.Utils.BinarySerialization/)

![](https://raw.githubusercontent.com/Dtopiast/OnionCrafter.Utils.BinarySerialization/main/Images/Logo.png)

**Estado de la Librer�a: Pre-Alfa - No Listo para Producci�n**

Esta librer�a se encuentra actualmente en un estado pre-alfa, lo que significa que est� en una fase muy temprana de desarrollo y no est� destinada para su uso en entornos de producci�n. Estamos trabajando arduamente para mejorar y estabilizar la librer�a, pero a�n pueden existir errores y limitaciones significativas.

Si est�s interesado en utilizar esta librer�a, te recomendamos encarecidamente que la pruebes en un entorno de desarrollo o pruebas para evaluar su idoneidad para tu proyecto. No se garantiza la estabilidad ni la compatibilidad con versiones futuras en este estado inicial.

Por favor, mantente atento a futuras actualizaciones y anuncios sobre el progreso de la librer�a. Tu retroalimentaci�n y contribuciones son bienvenidas a medida que avanzamos hacia una versi�n m�s estable y lista para producci�n.

## Descripci�n

**OnionCrafter.Util.BinarySerialization** es una librer�a de utilidades de serializaci�n binaria para .NET 7. Esta librer�a proporciona m�todos sencillos para la serializaci�n y deserializaci�n de objetos en formato binario. Utiliza opciones de serializaci�n JSON personalizables para garantizar una mayor flexibilidad.

## Caracter�sticas

- Serializa objetos a datos binarios.
- Deserializa datos binarios a objetos del tipo especificado.
- Opciones de serializaci�n JSON personalizables.
- F�cil de usar y ligera.

## Requisitos

- .NET 7

## Instalaci�n

Puedes agregar esta librer�a a tu proyecto .NET 7 a trav�s de NuGet. Usa el siguiente comando de NuGet para instalarla:

```bash
dotnet add package OnionCrafter.Util.BinarySerialization
```

## Uso

Para utilizar esta librer�a en tu proyecto, simplemente sigue los ejemplos a continuaci�n:

```csharp
// Serializar un objeto a datos binarios
var objetoSerializado = miObjeto.SerializeToBinary();

// Deserializar datos binarios a un objeto del tipo especificado
var objetoDeserializado = datosBinarios.DeserializeToObject<MiClase>();
```


## Contribuir

Si deseas contribuir a esta librer�a, �te damos la bienvenida! Puedes hacerlo de las siguientes maneras:

1. **Informa problemas:** Si encuentras alg�n problema o error, por favor, abre un [issue](https://github.com/dtopiast/OnionCrafter.Utils.Exception/issues).

2. **Env�a Pull Requests:** Si deseas agregar nuevas caracter�sticas o corregir errores existentes, no dudes en enviar un [pull request](https://github.com/dtopiast/OnionCrafter.Utils.Exception/pulls).
## Licencia

Este proyecto est� bajo la [Licencia Mozilla Public v. 2](LICENSE.txt). Consulta el archivo LICENSE.md para obtener m�s informaci�n.
