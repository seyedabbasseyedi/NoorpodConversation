﻿using NoorpodConversation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoorpodConversation.DataBase.Models
{

    public class NotPermissionInfo
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public PermissionEnum PermissionType { get; set; }
    }
}
