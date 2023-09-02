using OnionCrafter.Utils.Exception;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OnionCrafter.Util.BinarySerialization
{
    /// <summary>
    /// Provides methods for binary serialization and deserialization.
    /// </summary>
    public static class BinarySerializationExtension
    {
        /// <summary>
        /// Serializes an object to binary data.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>A byte array containing the serialized binary data.</returns>
        public static byte[] SerializeToBinary<T>(this T obj)
            where T : class
        {
            obj.ThrowIfNull();
            return Encoding.UTF8.GetBytes(JsonSerializer.Serialize(obj, GetJsonSerializerOptions()));
        }

        /// <summary>
        /// Deserializes binary data to an object of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="data">A byte array containing the binary data to deserialize.</param>
        /// <returns>The deserialized object of type T.</returns>
        public static T DeserializeToObject<T>(this byte[]? data)
            where T : class
        {
            var condition = data == null || !data.Any();
            data.ThrowIf<byte[]?, ArgumentNullException>(condition);
            return JsonSerializer.Deserialize<T>(data, GetJsonSerializerOptions()).ThrowIfNull<T, NullReferenceException>();
        }

        /// <summary>
        /// The inmutable and innaccessible for the programmer json serializer options.
        /// </summary>
        /// <returns></returns>
        private static JsonSerializerOptions GetJsonSerializerOptions()
        {
            return new JsonSerializerOptions()
            {
                PropertyNamingPolicy = null,
                WriteIndented = true,
                AllowTrailingCommas = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            };
        }
    }
}