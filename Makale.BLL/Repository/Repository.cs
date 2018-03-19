using Makale.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makale.BLL.Repository
{
    public class MakaleRepo : RepositoryBase<Makale.Models.Entities.Makale, int> { }
    public class KategoriRepo : RepositoryBase<Kategori, int> { }
    public class YorumRepo : RepositoryBase<Yorum, int> { }

   
}
