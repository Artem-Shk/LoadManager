
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoadManager;

public partial class Teacher
{
    [Key]
    public int Код { get; set; }

    public string Фио { get; set; } = null!;

    public string? Фамилия { get; set; }

    public string? Имя { get; set; }

    public string? Отчество { get; set; }

    public string? Атрибуты { get; set; }

    public string? Результат { get; set; }

    public string? Паспорт { get; set; }

    public string? Адрес { get; set; }

    public string? Телефон { get; set; }

    public string? МестоРождения { get; set; }

    public DateTime? ДатаРождения { get; set; }

    public string? Дети { get; set; }

    public string? ДатыРожденияДетей { get; set; }

    public string? Свидетельства { get; set; }

    public string? ДатаПоступления { get; set; }

    public int? МесяцевРаботы { get; set; }

    public string? Логин { get; set; }

    public string? ПаспортСерия { get; set; }

    public string? ПаспортНомер { get; set; }

    public string? ПаспортВыдан { get; set; }

    public string? Образование { get; set; }

    public string? Диплом { get; set; }

    public string? Должность { get; set; }

    public string? Звание { get; set; }

    public string? Степень { get; set; }

    public string? Прочее { get; set; }

    public string? Инвалидность { get; set; }

    public bool? ПолМуж { get; set; }

    public string? ФайлФото { get; set; }

    public string? Icq { get; set; }

    public string? Skype { get; set; }

    public DateTime? ПаспортДатаВыдачи { get; set; }

    public string? ПаспортКодПодр { get; set; }

    public string? Снилс { get; set; }

    public string? Инн { get; set; }

    public string? Богод { get; set; }

    public string? Боспециальность { get; set; }

    public string? Боквалификация { get; set; }

    public string? СтепеньНомер { get; set; }

    public string? СтепеньДата { get; set; }

    public string? АттестатНомер { get; set; }

    public string? АттестатДата { get; set; }

    public short? ОбщийСтаж { get; set; }

    public short? ПедСтаж { get; set; }

    public short? НаучСтаж { get; set; }

    public bool? Производственник { get; set; }

    public string? ИмяВмиру { get; set; }

    public string? Email { get; set; }

    public int? КодПользователя { get; set; }

    public DateTime? ДатаСозданияПароля { get; set; }

    public int? КодВоинскогоЗвания { get; set; }

    public string? БонаименованиеОрганизации { get; set; }

    public string? Тфамилия { get; set; }

    public string? Тимя { get; set; }

    public string? Тотчество { get; set; }

    public bool? IsDelete { get; set; }

    public int? КодСтудента { get; set; }

    public string? БывшаяФамилия { get; set; }

    public byte? ПедСтажМесяцев { get; set; }

    public byte? НаучСтажМесяцев { get; set; }


    public bool? СозданШколойХ { get; set; }

    public string? ИдентификаторScopus { get; set; }

    public string? ВнешнийId { get; set; }

    public bool? Тёзка { get; set; }

    public int? PhotoId { get; set; }
}
