using System.Linq.Expressions;
using GetBalance.DAL;
using GetBalance.DATA;

namespace _16_DBFirst_RepositoryDesing_Nortwind.Repositories
{
	public class GenericRepository <Tentity> where Tentity : class
	{

		private  AppDbContext  context;

		public GenericRepository()
		{
			context = new AppDbContext();
		}


		public List<Tentity> GetAll()
		{
			return context.Set<Tentity>().ToList();
		}

		public Tentity GetById(int id)
		{
			try
			{

				return context.Set<Tentity>().Find(id);
			}
			catch (Exception)
			{

				throw new Exception("Aranılan Kayıt Mevcut Değil!");
			}

		}


		public int Add(Tentity entity)
		{
			try
			{
				context.Set<Tentity>().Add(entity);
				return context.SaveChanges();
			}
			catch (Exception ex)
			{

				throw new Exception("Ekleme Başarısız"+ex);
			}
		}



		public int Delete(int id)
		{
			try
			{
				Tentity entityToDelete = GetById(id);
				context.Set<Tentity>().Remove(entityToDelete);
				return context.SaveChanges();
			}
			catch (Exception)
			{

				throw new Exception("Kayıt Silinemedi!");
			}
		}

		public int Delete(Tentity entity, int id)
		{
			Tentity entityToDelete = context.Set<Tentity>().Find(id);
			try
			{
				context.Set<Tentity>().Remove(entityToDelete);
				return context.SaveChanges();
			}
			catch (Exception)
			{

				throw new Exception("Kayıt Silinemedi!");
			}
		}

		public Tentity? GetByFilter(Expression<Func<Tentity, bool>> filter)
		{
			return context.Set<Tentity>().FirstOrDefault(filter);
		}
	}
}
