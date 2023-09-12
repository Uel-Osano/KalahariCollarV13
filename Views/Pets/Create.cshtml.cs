using KalahariCollarV13.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KalahariCollarV13.Views.Pets
{
    public class CreateModel: PageModel
    {
        private readonly KalahariCollarV13.Data.KalahariCollarV13AuthDbContext _context;

        public CreateModel(KalahariCollarV13.Data.KalahariCollarV13AuthDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pet pet { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyPet = new Pet();

            if (await TryUpdateModelAsync<Pet>(
                emptyPet,
                "pet",   // Prefix for form value.
                s => s.Name, s => s.Type, s => s.Breed, s => s.Location, s => s.OwnerId))
            {
                _context.Pet.Add(emptyPet);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
