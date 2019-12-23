﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZooContent
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ZooDb")]
	public partial class ZooDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    #endregion
		
		public ZooDbDataContext() : 
				base(global::ZooContent.Properties.Settings.Default.ZooDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ZooDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ZooDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ZooDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ZooDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Animal> Animal
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	[global::System.Data.Linq.Mapping.InheritanceMappingAttribute(Code="ZooAnimal", Type=typeof(ZooAnimal), IsDefault=true)]
	[global::System.Data.Linq.Mapping.InheritanceMappingAttribute(Code="Cat", Type=typeof(Cat))]
	public abstract partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private string _From;
		
		private double _Cost;
		
		private string _Nickname;
		
		private int _Age;
		
		private int _Height;
		
		private int _Weight;
		
		private string _Gender;
		
		private string _Reproduction;
		
		private int _Id = default(int);
		
		private string _AType;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFromChanging(string value);
    partial void OnFromChanged();
    partial void OnCostChanging(double value);
    partial void OnCostChanged();
    partial void OnNicknameChanging(string value);
    partial void OnNicknameChanged();
    partial void OnAgeChanging(int value);
    partial void OnAgeChanged();
    partial void OnHeightChanging(int value);
    partial void OnHeightChanged();
    partial void OnWeightChanging(int value);
    partial void OnWeightChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnReproductionChanging(string value);
    partial void OnReproductionChanged();
    partial void OnATypeChanging(string value);
    partial void OnATypeChanged();
    #endregion
		
		public Animal()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[From]", Storage="_From", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string From
		{
			get
			{
				return this._From;
			}
			set
			{
				if ((this._From != value))
				{
					this.OnFromChanging(value);
					this.SendPropertyChanging();
					this._From = value;
					this.SendPropertyChanged("From");
					this.OnFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Float NOT NULL")]
		public double Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nickname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nickname
		{
			get
			{
				return this._Nickname;
			}
			set
			{
				if ((this._Nickname != value))
				{
					this.OnNicknameChanging(value);
					this.SendPropertyChanging();
					this._Nickname = value;
					this.SendPropertyChanged("Nickname");
					this.OnNicknameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int NOT NULL")]
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="Int NOT NULL")]
		public int Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				if ((this._Height != value))
				{
					this.OnHeightChanging(value);
					this.SendPropertyChanging();
					this._Height = value;
					this.SendPropertyChanged("Height");
					this.OnHeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Int NOT NULL")]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reproduction", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Reproduction
		{
			get
			{
				return this._Reproduction;
			}
			set
			{
				if ((this._Reproduction != value))
				{
					this.OnReproductionChanging(value);
					this.SendPropertyChanging();
					this._Reproduction = value;
					this.SendPropertyChanged("Reproduction");
					this.OnReproductionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="INT", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int Id
		{
			get
			{
				return this._Id;
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AType", DbType="VARCHAR(50)", CanBeNull=false, IsDiscriminator=true)]
		public virtual string AType
		{
			get
			{
				return this._AType;
			}
			set
			{
				if ((this._AType != value))
				{
					this.OnATypeChanging(value);
					this.SendPropertyChanging();
					this._AType = value;
					this.SendPropertyChanged("AType");
					this.OnATypeChanged();
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
	
	public partial class ZooAnimal : Animal
	{
		
		private string _AType;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnATypeChanging(string value);
    partial void OnATypeChanged();
    #endregion
		
		public ZooAnimal()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AType", DbType="VARCHAR(50)", CanBeNull=false)]
		public override string AType
		{
			get
			{
				return this._AType;
			}
			set
			{
				if ((this._AType != value))
				{
					this.OnATypeChanging(value);
					this.SendPropertyChanging();
					this._AType = value;
					this.SendPropertyChanged("AType");
					this.OnATypeChanged();
				}
			}
		}
	}
	
	public partial class Cat : ZooAnimal
	{
		
		private string _Song;
		
		private string _AType;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSongChanging(string value);
    partial void OnSongChanged();
    partial void OnATypeChanging(string value);
    partial void OnATypeChanged();
    #endregion
		
		public Cat()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Song", CanBeNull=false)]
		public string Song
		{
			get
			{
				return this._Song;
			}
			set
			{
				if ((this._Song != value))
				{
					this.OnSongChanging(value);
					this.SendPropertyChanging();
					this._Song = value;
					this.SendPropertyChanged("Song");
					this.OnSongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AType", DbType="VARCHAR(50)", CanBeNull=false)]
		public override string AType
		{
			get
			{
				return this._AType;
			}
			set
			{
				if ((this._AType != value))
				{
					this.OnATypeChanging(value);
					this.SendPropertyChanging();
					this._AType = value;
					this.SendPropertyChanged("AType");
					this.OnATypeChanged();
				}
			}
		}
	}
}
#pragma warning restore 1591
