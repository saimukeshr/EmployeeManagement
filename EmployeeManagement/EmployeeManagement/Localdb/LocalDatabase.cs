using EmployeeManagement.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Localdb
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            //Establishing the conection
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Employee>().Wait();
        }

        // Show the registers
        public Task<List<Employee>> GetEmployeeAsync()
        {
            return _database.Table<Employee>().ToListAsync();
        }

        // Save registers
        public Task<int> SaveEmployeeAsync(Employee emp)
        {
            return _database.InsertAsync(emp);
        }

        // Delete registers
        public Task<int> DeleteEmployeeAsync(Employee emp)
        {
            return _database.DeleteAsync(emp);
        }

        // Save registers
        public Task<int> UpdateEmployeeAsync(Employee emp)
        {
            return _database.UpdateAsync(emp);
        }
    }

}
