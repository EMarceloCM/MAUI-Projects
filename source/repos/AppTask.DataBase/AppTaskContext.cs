using AppTask.Models;
using Microsoft.EntityFrameworkCore;

namespace AppTask.DataBase
{
    public class AppTaskContext : DbContext
    {
        //Tabelas
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<SubTaskModel> SubTasks { get; set; }

        public AppTaskContext()
        {
            //Cria o arquivo se nao existir, verifica se possui migrações caso exista
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dataBasePath = Path.Combine(folderPath, "apptask.db");

            optionsBuilder.UseSqlite($"FileName={dataBasePath}");
        }
    }
}