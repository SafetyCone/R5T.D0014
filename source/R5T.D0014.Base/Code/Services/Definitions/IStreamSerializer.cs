using System;
using System.IO;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0014
{
    /// <summary>
    /// De/serializes an object of type <typeparamref name="T"/> to a <see cref="Stream"/>.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IStreamSerializer<T> : IServiceDefinition
    {
        /// <summary>
        /// Deserializes an object from a <see cref="Stream"/>.
        /// </summary>
        Task<T> DeserializeAsync(Stream stream);

        /// <summary>
        /// Serializes an object to a <see cref="Stream"/>.
        /// </summary>
        Task SerializeAsync(Stream stream, T value);
    }
}
