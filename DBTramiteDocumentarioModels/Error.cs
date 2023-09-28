using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Error")]
public partial class Error
{
    [Key]
    public int IdError { get; set; }

    public string? Url { get; set; }

    public string? Controller { get; set; }

    public string? Ip { get; set; }

    public string? Method { get; set; }

    public string? UserAgent { get; set; }

    public string? Host { get; set; }

    public string? ClassComponent { get; set; }

    public string? FuctionName { get; set; }

    public int? LineNumber { get; set; }

    public string? Error1 { get; set; }

    public string? StackTrace { get; set; }

    public string? Status { get; set; }

    public string? Request { get; set; }

    public int? ErrorCode { get; set; }

    public int? IdPersona { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }
}
