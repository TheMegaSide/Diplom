using System;
using System.ComponentModel.DataAnnotations;

namespace FInalProject.Models
{
    public class CarNew
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Не выбран тип")]
        public string type { get; set; }
        [Required(ErrorMessage = "Не указана модель")]
        public string model{ get; set; }
        [Required(ErrorMessage = "Не указан VIN")]
        public string vin { get; set; }
        [Required(ErrorMessage = "Не указан год выпуска")]
        public int yearprod { get; set; }
        [Required(ErrorMessage = "Не указан гос.номер")]
        public string govnum{ get; set; }
        [Required(ErrorMessage = "Не указан объем")]
        public double value{ get; set; }
        [Required(ErrorMessage = "Не указан вес")]
        public int weight{ get; set; }
        [Required(ErrorMessage = "Не указан макс.вес")]
        public int maxweight{ get; set; }
        [Required(ErrorMessage = "Не указан тип топлива")]
        public string fueltype{ get; set; }
        [Required(ErrorMessage = "Не указано состояние")]
        public string techstate{ get; set; }
        [Required(ErrorMessage = "Не указан срок по ДК")]
        public DateTime srokpodk{ get; set; }
        [Required(ErrorMessage = "Не указана страховая компания")]
        public string inscomp{ get; set; }
        [Required(ErrorMessage = "Не указана стоимость страховки")]
        public double osagocost{ get; set; }
        [Required(ErrorMessage = "Не указан номер ПЛАТОН")]
        public string platonnum{ get; set; }
        [Required(ErrorMessage = "Не указана дата окончания срока службы БУ")]
        public DateTime platondate{ get; set; }
        [Required(ErrorMessage = "Не указан тип замены ПЛАТОН")]
        public string platonreplace{ get; set; }
        [Required(ErrorMessage = "Не указан тип ГЛОНАС")]
        public string glonastype{ get; set; }
        [Required(ErrorMessage = "Не указан номер ГЛОНАС")]
        public string simnum{ get; set; }
        [Required(ErrorMessage = "Не указана дата установки ГЛОНАС")]
        public DateTime glonasdate{ get; set; }
        [Required(ErrorMessage = "Не указан тип работы ГЛОНАС")]
        public string worktype{ get; set; }
        [Required(ErrorMessage = "Не указан владелец по ПТС")]
        public string ptsowner{ get; set; }
        [Required(ErrorMessage = "Не указан владелец по СТС")]
        public string stsowner{ get; set; }
        [Required(ErrorMessage = "Не указан регион")]
        public string regionloc{ get; set; }
    }
}