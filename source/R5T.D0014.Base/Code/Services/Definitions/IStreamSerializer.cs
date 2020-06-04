using System;
using System.IO;
using System.Threading.Tasks;


namespace R5T.D0014
{
    /// <summary>
    /// De/serializes an object of type <typeparamref name="T"/> to a <see cref="Stream"/>.
    /// </summary>
    public interface IStreamSerializer<T>
    {
        /// <summary>
        /// Deserializes an object from a <see cref="Stream"/>.
        /// </summary>
        /// <param name="filePath">The rooted file path to use.</param>
        Task<T> DeserializeAsync(string filePath);

        /// <summary>
        /// Serializes an object to a <see cref="Stream"/>.
        /// </summary>
        Task SerializeAsync(T value);
    }
}
