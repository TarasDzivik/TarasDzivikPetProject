using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TarasDzivikPetProject.Domain.Entities;
using TarasDzivikPetProject.Domain.Repositories.Abstract;

namespace TarasDzivikPetProject.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;

        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<TextField> GetTextFields()
        {
            return context.TestFields;
        }

        public TextField GetTextFieldById(Guid id)
        {
            return context.TestFields.FirstOrDefault(x => x.TextFieldId == id);
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return context.TestFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.TextFieldId == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public void DeleteTextField(Guid id)
        {
            context.TestFields.Remove(new TextField() { TextFieldId = id });
            context.SaveChanges();
        }
    }
}