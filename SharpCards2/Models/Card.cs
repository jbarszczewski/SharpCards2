namespace SharpCards2.Models {
	public class Card {
		public Guid Id { get; set; }
		public string Front { get; set; } = string.Empty;
		public string Back { get; set; } = string.Empty;
	}
}
