using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeword);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
