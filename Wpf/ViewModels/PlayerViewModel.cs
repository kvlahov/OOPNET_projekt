using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Model;

namespace Wpf.ViewModels
{
	public class PlayerViewModel : ViewModelBase
	{
		private int _playerNumber;
		public int PlayerNumber
		{
			get { return _playerNumber; }
			set { SetProperty(ref _playerNumber, value); }
		}

		private string _playerName;
		public string PlayerName
		{
			get { return _playerName; }
			set { SetProperty(ref _playerName, value); }
		}

		public string ShortenedPlayerName
		{
			get { return GetFormatedPlayerName(_playerName); }
		}


		private bool _isCaptain = true;
		public bool IsCaptain
		{
			get { return _isCaptain; }
			set { SetProperty(ref _isCaptain, value); }
		}

		private bool _isHomeTeam = true;
		public bool IsHomeTeam
		{
			get { return _isHomeTeam; }
			set { SetProperty(ref _isHomeTeam, value); }
		}

		private Position _position;
		public Position Position
		{
			get { return _position; }
			set { SetProperty(ref _position, value); }
		}

		private int _noOfYellowCards;
		public int NoOfYellowCards
		{
			get { return _noOfYellowCards; }
			set { SetProperty(ref _noOfYellowCards, value); }
		}

		private int _noOfGoals;

		public int NoOfGoals
		{
			get { return _noOfGoals; }
			set { SetProperty(ref _noOfGoals, value); }
		}

		private string GetFormatedPlayerName(string playerName)
		{
			if (string.IsNullOrWhiteSpace(playerName))
			{
				return "";
			}

			var nameArray = playerName.Split(new char[] { ' ' }, 2);
			var textInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
			return nameArray.Length == 2 ? $"{nameArray[0].First()}. {textInfo.ToTitleCase(nameArray[1].ToLower())}" : playerName;
		}
	}
}
