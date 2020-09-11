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

namespace BCTest
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BCTest")]
	public partial class LotMapDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLot(Lot instance);
    partial void UpdateLot(Lot instance);
    partial void DeleteLot(Lot instance);
    #endregion
		
		public LotMapDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BCTestConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LotMapDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LotMapDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LotMapDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LotMapDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Lot> Lots
		{
			get
			{
				return this.GetTable<Lot>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lots")]
	public partial class Lot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _X_CoOrd;
		
		private System.Nullable<int> _Y_CoOrd;
		
		private System.Nullable<int> _LotNo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnX_CoOrdChanging(System.Nullable<int> value);
    partial void OnX_CoOrdChanged();
    partial void OnY_CoOrdChanging(System.Nullable<int> value);
    partial void OnY_CoOrdChanged();
    partial void OnLotNoChanging(System.Nullable<int> value);
    partial void OnLotNoChanged();
    #endregion
		
		public Lot()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_X_CoOrd", DbType="Int")]
		public System.Nullable<int> X_CoOrd
		{
			get
			{
				return this._X_CoOrd;
			}
			set
			{
				if ((this._X_CoOrd != value))
				{
					this.OnX_CoOrdChanging(value);
					this.SendPropertyChanging();
					this._X_CoOrd = value;
					this.SendPropertyChanged("X_CoOrd");
					this.OnX_CoOrdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Y_CoOrd", DbType="Int")]
		public System.Nullable<int> Y_CoOrd
		{
			get
			{
				return this._Y_CoOrd;
			}
			set
			{
				if ((this._Y_CoOrd != value))
				{
					this.OnY_CoOrdChanging(value);
					this.SendPropertyChanging();
					this._Y_CoOrd = value;
					this.SendPropertyChanged("Y_CoOrd");
					this.OnY_CoOrdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LotNo", DbType="Int")]
		public System.Nullable<int> LotNo
		{
			get
			{
				return this._LotNo;
			}
			set
			{
				if ((this._LotNo != value))
				{
					this.OnLotNoChanging(value);
					this.SendPropertyChanging();
					this._LotNo = value;
					this.SendPropertyChanged("LotNo");
					this.OnLotNoChanged();
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