using aula_csharp_bd.db;

using System.Linq;

/* using (var db = new DbLivrariaContext()) {
   foreach (var autor in db.TbAutor.OrderBy(a => a.Nome)) {
   Console.WriteLine($"O autor {autor.Nome} é do {autor.Pais}!");
  }
} */

/*using (var db = new DbLivrariaContext()) {
   foreach (var autor in db.TbAutor.Where(a => a.Nome.Contains("Asano"))) {
   Console.WriteLine($"O autor {autor.Nome} é do {autor.Pais}!");
  }
}*/

/* using (var db = new DbLivrariaContext())
{
    var autor = db.TbAutor.Find(10);

    if (autor != null) 
    {
      Console.WriteLine($"O autor é {autor.Nome}");
    }
    else
    {
      Console.WriteLine("O autor é não esta no banco");
}   } */

/* using (var db = new DbLivrariaContext()) {
   var novoAutor = new TbAutor
   {

    Nome = "GeGe akutami",
    NrFone = "12345678910",
    Pais = "Japao"
   };

   db.TbAutor.Add(novoAutor);
   db.SaveChanges();
} */

using (var db = new DbLivrariaContext()) 
{
  var autor = db.TbAutor.SingleOrDefault(a => a.IdAutor == 6);

   if (autor != null)
   {
    db.TbAutor.Remove(autor);
    db.SaveChanges();
   }else {
    Console.WriteLine("Autor não identificado!");
   }

}