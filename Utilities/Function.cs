using System.Text;
using System.Security.Cryptography;
namespace Souvenir.Utilities
{
    public class Function
    {
        // Tạo alias slug từ title
        public static string TitleSlugGenerationAlias(string title)
        {
            return SlugGenerator.SlugGenerator.GenerateSlug(title);
        }
    }
}
