using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {
        /// <summary>
        /// Cria uma nova URL
        /// </summary>
        /// <param name="address">Endereço da URL</param>
        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalid(address);
        }

        /// <summary> 
        /// Endereço de URL
        /// </summary>
        public string Address { get; }
    }
}
