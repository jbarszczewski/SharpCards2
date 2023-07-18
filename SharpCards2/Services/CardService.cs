using SharpCards2.Models;

namespace SharpCards2.Services {
	internal class CardService : ICardService {
		public async Task<IEnumerable<Card>> GetItemsAsync() {
			await Task.Delay(2000);
			return new Card[] {
				new Card { Id = Guid.NewGuid(), Front = "Front 1", Back = "Back 1" },
				new Card { Id = Guid.NewGuid(), Front = "Front 2", Back = "Back 2" },
				new Card { Id = Guid.NewGuid(), Front = "Front 3", Back = "Back 3" }
			};
		}
	}

	public interface ICardService {
		Task<IEnumerable<Card>> GetItemsAsync();
	}
}
