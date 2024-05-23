using EFMapp.Entities.Library;
using EFMapp.Repositories;
using EFMapp.DbContexts;
using System.Net.Mime;



using (var context = new LibraryContext())
{
    LibraryRepository repo = new LibraryRepository(context);
  //  repo.Initialize();
    repo.ShowAll();
}