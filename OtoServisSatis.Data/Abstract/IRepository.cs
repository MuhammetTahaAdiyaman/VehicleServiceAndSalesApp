using System.Linq.Expressions;

namespace OtoServisSatis.Data.Abstract
{
	public interface IRepository<T> where T : class
	{
		//veri listeleme işlemleri
		List<T> GetAll();
		
		List<T> GetAll(Expression<Func<T, bool>> expression);

		T Get(Expression<Func<T, bool>> expression);

		T Find(int id);

		//ekleme işlemi
		void Add(T entity);
		
		void Update(T entity);
		
		void Delete(T entity);
		
		int Save();
		//asenkron metotlar
		Task<int> SaveAsync();

		Task<T> FindAsync(int id);

		Task<T> GetAsync(Expression<Func<T, bool>> expression);

		Task<List<T>> GetAllAsync();

		Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);

		Task AddAsync(T entity);

		
	}
}
