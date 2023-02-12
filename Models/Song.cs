using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models {
    public class Song {
        //Props

        public int SongId { get; set; }
        
        [Required] //Artist, Length och Category krävs.
        public string? Artist { get; set; }

        [Required]
        public int Length { get; set; }

        [Required]
        public string? Category { get; set; }

    }
}