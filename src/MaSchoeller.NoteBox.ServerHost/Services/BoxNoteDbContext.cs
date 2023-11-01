using MaSchoeller.NoteBox.ServerHost.Models;
using Microsoft.EntityFrameworkCore;

namespace MaSchoeller.NoteBox.ServerHost.Services;

public class BoxNoteDbContext : DbContext
{
    public BoxNoteDbContext(DbContextOptions<BoxNoteDbContext> options) : base(options)
    {

    }

    public DbSet<Card> Cards => Set<Card>();

    public DbSet<Source> Sources => Set<Source>();
}
