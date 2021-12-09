using System;
using System.Linq;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();              // Зробити вибірку усіх текстових полів.
        TextField GetTextFieldById(Guid id);                // Вибір текстового поля по ідентифікатору.
        TextField GetTextFieldByCodeWord(string codeWord);  // Вибір текстового поля то кодовому слову.
        void SaveTextField(TextField entity);               // Зберегти зміни в базу даних.
        void DeleteTextField(Guid id);                      // Видалити поле по ід.
    }
}