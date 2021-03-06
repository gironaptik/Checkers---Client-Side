﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ClientDB")]
	public partial class ClientGameDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTblPlayer(TblPlayer instance);
    partial void UpdateTblPlayer(TblPlayer instance);
    partial void DeleteTblPlayer(TblPlayer instance);
    partial void InsertTblGamesByPlayer(TblGamesByPlayer instance);
    partial void UpdateTblGamesByPlayer(TblGamesByPlayer instance);
    partial void DeleteTblGamesByPlayer(TblGamesByPlayer instance);
    partial void InsertTblGame(TblGame instance);
    partial void UpdateTblGame(TblGame instance);
    partial void DeleteTblGame(TblGame instance);
    partial void InsertTblTurnsHistory(TblTurnsHistory instance);
    partial void UpdateTblTurnsHistory(TblTurnsHistory instance);
    partial void DeleteTblTurnsHistory(TblTurnsHistory instance);
    #endregion
		
		public ClientGameDataContext() : 
				base(global::Client.Properties.Settings.Default.ClientDBConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public ClientGameDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClientGameDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClientGameDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClientGameDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TblPlayer> TblPlayers
		{
			get
			{
				return this.GetTable<TblPlayer>();
			}
		}
		
		public System.Data.Linq.Table<TblGamesByPlayer> TblGamesByPlayers
		{
			get
			{
				return this.GetTable<TblGamesByPlayer>();
			}
		}
		
		public System.Data.Linq.Table<TblGame> TblGames
		{
			get
			{
				return this.GetTable<TblGame>();
			}
		}
		
		public System.Data.Linq.Table<TblTurnsHistory> TblTurnsHistories
		{
			get
			{
				return this.GetTable<TblTurnsHistory>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblPlayers")]
	public partial class TblPlayer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Password;
		
		private System.Nullable<int> _NumOfGames;
		
		private string _Email;
		
		private EntitySet<TblGamesByPlayer> _TblGamesByPlayers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnNumOfGamesChanging(System.Nullable<int> value);
    partial void OnNumOfGamesChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public TblPlayer()
		{
			this._TblGamesByPlayers = new EntitySet<TblGamesByPlayer>(new Action<TblGamesByPlayer>(this.attach_TblGamesByPlayers), new Action<TblGamesByPlayer>(this.detach_TblGamesByPlayers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumOfGames", DbType="Int")]
		public System.Nullable<int> NumOfGames
		{
			get
			{
				return this._NumOfGames;
			}
			set
			{
				if ((this._NumOfGames != value))
				{
					this.OnNumOfGamesChanging(value);
					this.SendPropertyChanging();
					this._NumOfGames = value;
					this.SendPropertyChanged("NumOfGames");
					this.OnNumOfGamesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblPlayer_TblGamesByPlayer", Storage="_TblGamesByPlayers", ThisKey="Id", OtherKey="IdPlayer")]
		public EntitySet<TblGamesByPlayer> TblGamesByPlayers
		{
			get
			{
				return this._TblGamesByPlayers;
			}
			set
			{
				this._TblGamesByPlayers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TblGamesByPlayers(TblGamesByPlayer entity)
		{
			this.SendPropertyChanging();
			entity.TblPlayer = this;
		}
		
		private void detach_TblGamesByPlayers(TblGamesByPlayer entity)
		{
			this.SendPropertyChanging();
			entity.TblPlayer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblGamesByPlayer")]
	public partial class TblGamesByPlayer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdGame;
		
		private int _IdPlayer;
		
		private EntityRef<TblPlayer> _TblPlayer;
		
		private EntityRef<TblGame> _TblGame;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdGameChanging(int value);
    partial void OnIdGameChanged();
    partial void OnIdPlayerChanging(int value);
    partial void OnIdPlayerChanged();
    #endregion
		
		public TblGamesByPlayer()
		{
			this._TblPlayer = default(EntityRef<TblPlayer>);
			this._TblGame = default(EntityRef<TblGame>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdGame", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdGame
		{
			get
			{
				return this._IdGame;
			}
			set
			{
				if ((this._IdGame != value))
				{
					if (this._TblGame.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdGameChanging(value);
					this.SendPropertyChanging();
					this._IdGame = value;
					this.SendPropertyChanged("IdGame");
					this.OnIdGameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPlayer", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdPlayer
		{
			get
			{
				return this._IdPlayer;
			}
			set
			{
				if ((this._IdPlayer != value))
				{
					if (this._TblPlayer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdPlayerChanging(value);
					this.SendPropertyChanging();
					this._IdPlayer = value;
					this.SendPropertyChanged("IdPlayer");
					this.OnIdPlayerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblPlayer_TblGamesByPlayer", Storage="_TblPlayer", ThisKey="IdPlayer", OtherKey="Id", IsForeignKey=true)]
		public TblPlayer TblPlayer
		{
			get
			{
				return this._TblPlayer.Entity;
			}
			set
			{
				TblPlayer previousValue = this._TblPlayer.Entity;
				if (((previousValue != value) 
							|| (this._TblPlayer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblPlayer.Entity = null;
						previousValue.TblGamesByPlayers.Remove(this);
					}
					this._TblPlayer.Entity = value;
					if ((value != null))
					{
						value.TblGamesByPlayers.Add(this);
						this._IdPlayer = value.Id;
					}
					else
					{
						this._IdPlayer = default(int);
					}
					this.SendPropertyChanged("TblPlayer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblGame_TblGamesByPlayer", Storage="_TblGame", ThisKey="IdGame", OtherKey="Id", IsForeignKey=true)]
		public TblGame TblGame
		{
			get
			{
				return this._TblGame.Entity;
			}
			set
			{
				TblGame previousValue = this._TblGame.Entity;
				if (((previousValue != value) 
							|| (this._TblGame.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblGame.Entity = null;
						previousValue.TblGamesByPlayers.Remove(this);
					}
					this._TblGame.Entity = value;
					if ((value != null))
					{
						value.TblGamesByPlayers.Add(this);
						this._IdGame = value.Id;
					}
					else
					{
						this._IdGame = default(int);
					}
					this.SendPropertyChanged("TblGame");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblGames")]
	public partial class TblGame : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _PlayerId;
		
		private string _Date;
		
		private EntitySet<TblGamesByPlayer> _TblGamesByPlayers;
		
		private EntitySet<TblTurnsHistory> _TblTurnsHistories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPlayerIdChanging(int value);
    partial void OnPlayerIdChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    #endregion
		
		public TblGame()
		{
			this._TblGamesByPlayers = new EntitySet<TblGamesByPlayer>(new Action<TblGamesByPlayer>(this.attach_TblGamesByPlayers), new Action<TblGamesByPlayer>(this.detach_TblGamesByPlayers));
			this._TblTurnsHistories = new EntitySet<TblTurnsHistory>(new Action<TblTurnsHistory>(this.attach_TblTurnsHistories), new Action<TblTurnsHistory>(this.detach_TblTurnsHistories));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="Int NOT NULL")]
		public int PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblGame_TblGamesByPlayer", Storage="_TblGamesByPlayers", ThisKey="Id", OtherKey="IdGame")]
		public EntitySet<TblGamesByPlayer> TblGamesByPlayers
		{
			get
			{
				return this._TblGamesByPlayers;
			}
			set
			{
				this._TblGamesByPlayers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblGame_TblTurnsHistory", Storage="_TblTurnsHistories", ThisKey="Id", OtherKey="GameId")]
		public EntitySet<TblTurnsHistory> TblTurnsHistories
		{
			get
			{
				return this._TblTurnsHistories;
			}
			set
			{
				this._TblTurnsHistories.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TblGamesByPlayers(TblGamesByPlayer entity)
		{
			this.SendPropertyChanging();
			entity.TblGame = this;
		}
		
		private void detach_TblGamesByPlayers(TblGamesByPlayer entity)
		{
			this.SendPropertyChanging();
			entity.TblGame = null;
		}
		
		private void attach_TblTurnsHistories(TblTurnsHistory entity)
		{
			this.SendPropertyChanging();
			entity.TblGame = this;
		}
		
		private void detach_TblTurnsHistories(TblTurnsHistory entity)
		{
			this.SendPropertyChanging();
			entity.TblGame = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblTurnsHistory")]
	public partial class TblTurnsHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _GameId;
		
		private int _TurnNumber;
		
		private System.Nullable<int> _FromIPoint;
		
		private System.Nullable<int> _FromJPoint;
		
		private System.Nullable<int> _ToIPoint;
		
		private System.Nullable<int> _ToJPoint;
		
		private EntityRef<TblGame> _TblGame;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnGameIdChanging(int value);
    partial void OnGameIdChanged();
    partial void OnTurnNumberChanging(int value);
    partial void OnTurnNumberChanged();
    partial void OnFromIPointChanging(System.Nullable<int> value);
    partial void OnFromIPointChanged();
    partial void OnFromJPointChanging(System.Nullable<int> value);
    partial void OnFromJPointChanged();
    partial void OnToIPointChanging(System.Nullable<int> value);
    partial void OnToIPointChanged();
    partial void OnToJPointChanging(System.Nullable<int> value);
    partial void OnToJPointChanged();
    #endregion
		
		public TblTurnsHistory()
		{
			this._TblGame = default(EntityRef<TblGame>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameId", DbType="Int NOT NULL")]
		public int GameId
		{
			get
			{
				return this._GameId;
			}
			set
			{
				if ((this._GameId != value))
				{
					if (this._TblGame.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGameIdChanging(value);
					this.SendPropertyChanging();
					this._GameId = value;
					this.SendPropertyChanged("GameId");
					this.OnGameIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TurnNumber", DbType="Int NOT NULL")]
		public int TurnNumber
		{
			get
			{
				return this._TurnNumber;
			}
			set
			{
				if ((this._TurnNumber != value))
				{
					this.OnTurnNumberChanging(value);
					this.SendPropertyChanging();
					this._TurnNumber = value;
					this.SendPropertyChanged("TurnNumber");
					this.OnTurnNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromIPoint", DbType="Int")]
		public System.Nullable<int> FromIPoint
		{
			get
			{
				return this._FromIPoint;
			}
			set
			{
				if ((this._FromIPoint != value))
				{
					this.OnFromIPointChanging(value);
					this.SendPropertyChanging();
					this._FromIPoint = value;
					this.SendPropertyChanged("FromIPoint");
					this.OnFromIPointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromJPoint", DbType="Int")]
		public System.Nullable<int> FromJPoint
		{
			get
			{
				return this._FromJPoint;
			}
			set
			{
				if ((this._FromJPoint != value))
				{
					this.OnFromJPointChanging(value);
					this.SendPropertyChanging();
					this._FromJPoint = value;
					this.SendPropertyChanged("FromJPoint");
					this.OnFromJPointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToIPoint", DbType="Int")]
		public System.Nullable<int> ToIPoint
		{
			get
			{
				return this._ToIPoint;
			}
			set
			{
				if ((this._ToIPoint != value))
				{
					this.OnToIPointChanging(value);
					this.SendPropertyChanging();
					this._ToIPoint = value;
					this.SendPropertyChanged("ToIPoint");
					this.OnToIPointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToJPoint", DbType="Int")]
		public System.Nullable<int> ToJPoint
		{
			get
			{
				return this._ToJPoint;
			}
			set
			{
				if ((this._ToJPoint != value))
				{
					this.OnToJPointChanging(value);
					this.SendPropertyChanging();
					this._ToJPoint = value;
					this.SendPropertyChanged("ToJPoint");
					this.OnToJPointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblGame_TblTurnsHistory", Storage="_TblGame", ThisKey="GameId", OtherKey="Id", IsForeignKey=true)]
		public TblGame TblGame
		{
			get
			{
				return this._TblGame.Entity;
			}
			set
			{
				TblGame previousValue = this._TblGame.Entity;
				if (((previousValue != value) 
							|| (this._TblGame.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblGame.Entity = null;
						previousValue.TblTurnsHistories.Remove(this);
					}
					this._TblGame.Entity = value;
					if ((value != null))
					{
						value.TblTurnsHistories.Add(this);
						this._GameId = value.Id;
					}
					else
					{
						this._GameId = default(int);
					}
					this.SendPropertyChanged("TblGame");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
