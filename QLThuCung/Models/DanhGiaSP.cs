﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace QLThuCung.Models
{
    public class DanhGiaSP
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(1,5)]
        public int Sao { get; set; }
        [Required]
        [StringLength(500)]
        public string NoiDung { get; set; }
        [Required]
        public DateTime NgayTao { get; set; }
        [ForeignKey(nameof(HoaDonSanPham))]
        public int IdHoaDon { get; set; }
        [ValidateNever]
        public HoaDonSanPham HoaDonSanPham { get; set; }
        public ICollection<TepDinhKemDanhGiaSP> TepDinhKem { get; set; }
    }
}
