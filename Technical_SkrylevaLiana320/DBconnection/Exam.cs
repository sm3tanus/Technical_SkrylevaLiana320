//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Technical_SkrylevaLiana320.DBconnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public int code { get; set; }
        public Nullable<int> stud_id { get; set; }
        public Nullable<int> teacher_id { get; set; }
        public string cabinet { get; set; }
        public Nullable<int> score { get; set; }
    
        public virtual Discipline Discipline { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Student Student { get; set; }
    }
}