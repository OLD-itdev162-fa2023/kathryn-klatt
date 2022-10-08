using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Posts.Any()){
                var Posts = new List<Post>{
                    new Post {
                        Title = "First post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam sodales pharetra viverra. In tincidunt tortor a velit faucibus hendrerit. In auctor erat augue, ac ultrices justo facilisis non. In placerat nisi eget faucibus euismod. Vivamus lorem ligula, mollis non odio eget, feugiat pharetra libero. Vivamus luctus vestibulum quam, nec volutpat augue congue sit amet. Etiam id nulla magna. Etiam malesuada, arcu nec egestas rutrum, sapien erat laoreet leo, quis venenatis magna massa eu urna. Donec laoreet quis augue at ultrices. Morbi sed convallis enim. Fusce sem erat, aliquet sed iaculis in, posuere convallis dui.",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Second post",
                        Body = "In eu placerat lacus. Sed massa justo, tincidunt sit amet convallis sed, hendrerit et dui. In hac habitasse platea dictumst. Nulla sit amet justo sit amet odio fringilla hendrerit. Nulla eu metus placerat, rutrum metus tristique, faucibus erat. Ut vitae commodo libero. Morbi rutrum neque eu tortor vehicula, eu fringilla dui pharetra. Vivamus ut lorem vel dolor tincidunt scelerisque at non lacus. Sed ac justo velit. Morbi quis sollicitudin ante, vitae finibus dolor. Sed lobortis lectus vitae eros efficitur, eu semper magna pulvinar. Donec at cursus dui, quis fermentum augue. Vivamus ultrices tempor ligula. Maecenas viverra aliquam tellus consequat luctus. Quisque nisi est, ultrices eget tellus eget, euismod venenatis nunc. Nulla vestibulum tellus ac faucibus tincidunt.",
                        Date = DateTime.Now.AddDays(-7)
                    },
                    new Post {
                        Title = "Third post",
                        Body = "Nam vitae turpis ac metus fringilla bibendum nec viverra quam. Donec sit amet convallis eros. Etiam tempus luctus ex, vitae laoreet felis hendrerit sed. Morbi turpis dolor, aliquet ac fermentum ut, volutpat pharetra ligula. Nam erat libero, auctor quis pellentesque eu, dictum quis mi. Suspendisse tempor odio neque. Aenean nec libero ut augue viverra viverra. Maecenas ut ipsum vitae dui congue bibendum ut in sem. In feugiat imperdiet nulla. Proin sit amet ligula varius, fermentum lorem ac, placerat metus. Pellentesque at tempor turpis, dapibus blandit sapien. Nam eget dolor sed eros ullamcorper egestas. Phasellus leo tortor, maximus id turpis ac, mattis finibus velit.",
                        Date = DateTime.Now.AddDays(-4)
                    },
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}