using System;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Model
{
    public class ModalFormModel
    {
        [Required(ErrorMessage = "Поле \'название\' является обязательным")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Поле \'описание\' является обязательным")]
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
    }
}
