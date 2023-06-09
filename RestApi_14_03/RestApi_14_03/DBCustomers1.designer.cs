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

namespace RestApi_14_03
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLKHACH_API")]
	public partial class DBCustomers1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSach(Sach instance);
    partial void UpdateSach(Sach instance);
    partial void DeleteSach(Sach instance);
    #endregion
		
		public DBCustomers1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLKHACH_APIConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBCustomers1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBCustomers1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBCustomers1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBCustomers1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Sach> Saches
		{
			get
			{
				return this.GetTable<Sach>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sach")]
	public partial class Sach : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSach;
		
		private string _TenSach;
		
		private string _GiaSach;
		
		private System.Nullable<int> _SLSach;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSachChanging(string value);
    partial void OnMaSachChanged();
    partial void OnTenSachChanging(string value);
    partial void OnTenSachChanged();
    partial void OnGiaSachChanging(string value);
    partial void OnGiaSachChanged();
    partial void OnSLSachChanging(System.Nullable<int> value);
    partial void OnSLSachChanged();
    #endregion
		
		public Sach()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSach", DbType="NVarChar(50)")]
		public string TenSach
		{
			get
			{
				return this._TenSach;
			}
			set
			{
				if ((this._TenSach != value))
				{
					this.OnTenSachChanging(value);
					this.SendPropertyChanging();
					this._TenSach = value;
					this.SendPropertyChanged("TenSach");
					this.OnTenSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaSach", DbType="NVarChar(50)")]
		public string GiaSach
		{
			get
			{
				return this._GiaSach;
			}
			set
			{
				if ((this._GiaSach != value))
				{
					this.OnGiaSachChanging(value);
					this.SendPropertyChanging();
					this._GiaSach = value;
					this.SendPropertyChanged("GiaSach");
					this.OnGiaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLSach", DbType="Int")]
		public System.Nullable<int> SLSach
		{
			get
			{
				return this._SLSach;
			}
			set
			{
				if ((this._SLSach != value))
				{
					this.OnSLSachChanging(value);
					this.SendPropertyChanging();
					this._SLSach = value;
					this.SendPropertyChanged("SLSach");
					this.OnSLSachChanged();
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
