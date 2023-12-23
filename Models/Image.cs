using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Image
    {
        [Key] public int ImageId { get; set; }
        [Required] public string? ImageTitle { get; set; }
        [Required] public byte[]? ImageData { get; set; }

        public static Image NewImage(
            int id,
            string title
        )
        {
            return new Image
            {
                ImageId = id,
                ImageData = new byte[] {0x00, 0x00, 0x00, 0x00, 0x00, 0x60, 0x06, 0x00, 0x01, 0xc1, 0x83, 0x80, 0x07, 0xc3, 0xc3, 0xe0,
    0x0f, 0xe3, 0xc7, 0xf0, 0x0f, 0xff, 0xff, 0xf0, 0x1f, 0xff, 0xff, 0xf8, 0x1f, 0xff, 0xff, 0xf8,
    0x0f, 0xff, 0xff, 0xf0, 0x0f, 0x3b, 0xdc, 0xf0, 0x06, 0x01, 0x80, 0x60, 0x03, 0x01, 0x80, 0xc0,
    0x00, 0x00, 0x00, 0x00 },
                ImageTitle = title,
            };
        }
    }
}