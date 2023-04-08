using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Campaign : ValueObject
    {
        /// <summary>
        /// Cria uma nova campanha
        /// </summary>
        /// <param name="source">A referencia</param>
        /// <param name="medium">Marketing medium</param>
        /// <param name="name">Produto, promoção código</param>
        /// <param name="id">Id do anúncio</param>
        /// <param name="term">Palavras chaves</param>
        /// <param name="content">Diferentes conteudos</param>
        public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;

            InvalidCampaignException.ThrowIfNull(source, "UTM Source is invalid");
            InvalidCampaignException.ThrowIfNull(medium, "UTM Medium is invalid");
            InvalidCampaignException.ThrowIfNull(name, "UTM Name is invalid");
        }

        public string? Id { get; set; }
        public string Source { get; }
        public string Medium { get; }
        public string Name { get; }
        public string? Term { get; set; }
        public string? Content { get; set; }
    }
}
 