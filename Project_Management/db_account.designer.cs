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

namespace Project_Management
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProjectManagement")]
	public partial class db_accountDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttb_account(tb_account instance);
    partial void Updatetb_account(tb_account instance);
    partial void Deletetb_account(tb_account instance);
    partial void Inserttb_section(tb_section instance);
    partial void Updatetb_section(tb_section instance);
    partial void Deletetb_section(tb_section instance);
    partial void Inserttb_group(tb_group instance);
    partial void Updatetb_group(tb_group instance);
    partial void Deletetb_group(tb_group instance);
    partial void Inserttb_groupMember(tb_groupMember instance);
    partial void Updatetb_groupMember(tb_groupMember instance);
    partial void Deletetb_groupMember(tb_groupMember instance);
    #endregion
		
		public db_accountDataContext() : 
				base(global::Project_Management.Properties.Settings.Default.ProjectManagementConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public db_accountDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public db_accountDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public db_accountDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public db_accountDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tb_account> tb_accounts
		{
			get
			{
				return this.GetTable<tb_account>();
			}
		}
		
		public System.Data.Linq.Table<tb_section> tb_sections
		{
			get
			{
				return this.GetTable<tb_section>();
			}
		}
		
		public System.Data.Linq.Table<tb_group> tb_groups
		{
			get
			{
				return this.GetTable<tb_group>();
			}
		}
		
		public System.Data.Linq.Table<tb_groupMember> tb_groupMembers
		{
			get
			{
				return this.GetTable<tb_groupMember>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_account")]
	public partial class tb_account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ac_serial;
		
		private string _ac_name;
		
		private string _ac_email;
		
		private string _ac_username;
		
		private string _ac_password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onac_serialChanging(int value);
    partial void Onac_serialChanged();
    partial void Onac_nameChanging(string value);
    partial void Onac_nameChanged();
    partial void Onac_emailChanging(string value);
    partial void Onac_emailChanged();
    partial void Onac_usernameChanging(string value);
    partial void Onac_usernameChanged();
    partial void Onac_passwordChanging(string value);
    partial void Onac_passwordChanged();
    #endregion
		
		public tb_account()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ac_serial", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ac_serial
		{
			get
			{
				return this._ac_serial;
			}
			set
			{
				if ((this._ac_serial != value))
				{
					this.Onac_serialChanging(value);
					this.SendPropertyChanging();
					this._ac_serial = value;
					this.SendPropertyChanged("ac_serial");
					this.Onac_serialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ac_name", DbType="VarChar(150)")]
		public string ac_name
		{
			get
			{
				return this._ac_name;
			}
			set
			{
				if ((this._ac_name != value))
				{
					this.Onac_nameChanging(value);
					this.SendPropertyChanging();
					this._ac_name = value;
					this.SendPropertyChanged("ac_name");
					this.Onac_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ac_email", DbType="VarChar(150)")]
		public string ac_email
		{
			get
			{
				return this._ac_email;
			}
			set
			{
				if ((this._ac_email != value))
				{
					this.Onac_emailChanging(value);
					this.SendPropertyChanging();
					this._ac_email = value;
					this.SendPropertyChanged("ac_email");
					this.Onac_emailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ac_username", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ac_username
		{
			get
			{
				return this._ac_username;
			}
			set
			{
				if ((this._ac_username != value))
				{
					this.Onac_usernameChanging(value);
					this.SendPropertyChanging();
					this._ac_username = value;
					this.SendPropertyChanged("ac_username");
					this.Onac_usernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ac_password", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string ac_password
		{
			get
			{
				return this._ac_password;
			}
			set
			{
				if ((this._ac_password != value))
				{
					this.Onac_passwordChanging(value);
					this.SendPropertyChanging();
					this._ac_password = value;
					this.SendPropertyChanged("ac_password");
					this.Onac_passwordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_section")]
	public partial class tb_section : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _serial;
		
		private string _sec_st_name;
		
		private string _sec_st_id;
		
		private string _sec_st_section;
		
		private string _sec_semester;
		
		private string _sec_inGroup;
		
		private string _sec_subject;
		
		private string _sec_username;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnserialChanging(int value);
    partial void OnserialChanged();
    partial void Onsec_st_nameChanging(string value);
    partial void Onsec_st_nameChanged();
    partial void Onsec_st_idChanging(string value);
    partial void Onsec_st_idChanged();
    partial void Onsec_st_sectionChanging(string value);
    partial void Onsec_st_sectionChanged();
    partial void Onsec_semesterChanging(string value);
    partial void Onsec_semesterChanged();
    partial void Onsec_inGroupChanging(string value);
    partial void Onsec_inGroupChanged();
    partial void Onsec_subjectChanging(string value);
    partial void Onsec_subjectChanged();
    partial void Onsec_usernameChanging(string value);
    partial void Onsec_usernameChanged();
    #endregion
		
		public tb_section()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serial", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int serial
		{
			get
			{
				return this._serial;
			}
			set
			{
				if ((this._serial != value))
				{
					this.OnserialChanging(value);
					this.SendPropertyChanging();
					this._serial = value;
					this.SendPropertyChanged("serial");
					this.OnserialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sec_st_name", DbType="VarChar(150)")]
		public string sec_st_name
		{
			get
			{
				return this._sec_st_name;
			}
			set
			{
				if ((this._sec_st_name != value))
				{
					this.Onsec_st_nameChanging(value);
					this.SendPropertyChanging();
					this._sec_st_name = value;
					this.SendPropertyChanged("sec_st_name");
					this.Onsec_st_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sec_st_id", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string sec_st_id
		{
			get
			{
				return this._sec_st_id;
			}
			set
			{
				if ((this._sec_st_id != value))
				{
					this.Onsec_st_idChanging(value);
					this.SendPropertyChanging();
					this._sec_st_id = value;
					this.SendPropertyChanged("sec_st_id");
					this.Onsec_st_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sec_st_section", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string sec_st_section
		{
			get
			{
				return this._sec_st_section;
			}
			set
			{
				if ((this._sec_st_section != value))
				{
					this.Onsec_st_sectionChanging(value);
					this.SendPropertyChanging();
					this._sec_st_section = value;
					this.SendPropertyChanged("sec_st_section");
					this.Onsec_st_sectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sec_semester", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string sec_semester
		{
			get
			{
				return this._sec_semester;
			}
			set
			{
				if ((this._sec_semester != value))
				{
					this.Onsec_semesterChanging(value);
					this.SendPropertyChanging();
					this._sec_semester = value;
					this.SendPropertyChanged("sec_semester");
					this.Onsec_semesterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sec_inGroup", DbType="VarChar(50)")]
		public string sec_inGroup
		{
			get
			{
				return this._sec_inGroup;
			}
			set
			{
				if ((this._sec_inGroup != value))
				{
					this.Onsec_inGroupChanging(value);
					this.SendPropertyChanging();
					this._sec_inGroup = value;
					this.SendPropertyChanged("sec_inGroup");
					this.Onsec_inGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sec_subject", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string sec_subject
		{
			get
			{
				return this._sec_subject;
			}
			set
			{
				if ((this._sec_subject != value))
				{
					this.Onsec_subjectChanging(value);
					this.SendPropertyChanging();
					this._sec_subject = value;
					this.SendPropertyChanged("sec_subject");
					this.Onsec_subjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sec_username", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string sec_username
		{
			get
			{
				return this._sec_username;
			}
			set
			{
				if ((this._sec_username != value))
				{
					this.Onsec_usernameChanging(value);
					this.SendPropertyChanging();
					this._sec_username = value;
					this.SendPropertyChanged("sec_username");
					this.Onsec_usernameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_group")]
	public partial class tb_group : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _grp_groupNumber;
		
		private string _grp_groupName;
		
		private string _grp_projectTitle;
		
		private System.Nullable<int> _grp_NumberOfMember;
		
		private string _grp_semester;
		
		private string _grp_subject;
		
		private string _grp_userName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ongrp_groupNumberChanging(string value);
    partial void Ongrp_groupNumberChanged();
    partial void Ongrp_groupNameChanging(string value);
    partial void Ongrp_groupNameChanged();
    partial void Ongrp_projectTitleChanging(string value);
    partial void Ongrp_projectTitleChanged();
    partial void Ongrp_NumberOfMemberChanging(System.Nullable<int> value);
    partial void Ongrp_NumberOfMemberChanged();
    partial void Ongrp_semesterChanging(string value);
    partial void Ongrp_semesterChanged();
    partial void Ongrp_subjectChanging(string value);
    partial void Ongrp_subjectChanged();
    partial void Ongrp_userNameChanging(string value);
    partial void Ongrp_userNameChanged();
    #endregion
		
		public tb_group()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grp_groupNumber", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string grp_groupNumber
		{
			get
			{
				return this._grp_groupNumber;
			}
			set
			{
				if ((this._grp_groupNumber != value))
				{
					this.Ongrp_groupNumberChanging(value);
					this.SendPropertyChanging();
					this._grp_groupNumber = value;
					this.SendPropertyChanged("grp_groupNumber");
					this.Ongrp_groupNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grp_groupName", DbType="VarChar(150)")]
		public string grp_groupName
		{
			get
			{
				return this._grp_groupName;
			}
			set
			{
				if ((this._grp_groupName != value))
				{
					this.Ongrp_groupNameChanging(value);
					this.SendPropertyChanging();
					this._grp_groupName = value;
					this.SendPropertyChanged("grp_groupName");
					this.Ongrp_groupNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grp_projectTitle", DbType="VarChar(150)")]
		public string grp_projectTitle
		{
			get
			{
				return this._grp_projectTitle;
			}
			set
			{
				if ((this._grp_projectTitle != value))
				{
					this.Ongrp_projectTitleChanging(value);
					this.SendPropertyChanging();
					this._grp_projectTitle = value;
					this.SendPropertyChanged("grp_projectTitle");
					this.Ongrp_projectTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grp_NumberOfMember", DbType="Int")]
		public System.Nullable<int> grp_NumberOfMember
		{
			get
			{
				return this._grp_NumberOfMember;
			}
			set
			{
				if ((this._grp_NumberOfMember != value))
				{
					this.Ongrp_NumberOfMemberChanging(value);
					this.SendPropertyChanging();
					this._grp_NumberOfMember = value;
					this.SendPropertyChanged("grp_NumberOfMember");
					this.Ongrp_NumberOfMemberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grp_semester", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string grp_semester
		{
			get
			{
				return this._grp_semester;
			}
			set
			{
				if ((this._grp_semester != value))
				{
					this.Ongrp_semesterChanging(value);
					this.SendPropertyChanging();
					this._grp_semester = value;
					this.SendPropertyChanged("grp_semester");
					this.Ongrp_semesterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grp_subject", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string grp_subject
		{
			get
			{
				return this._grp_subject;
			}
			set
			{
				if ((this._grp_subject != value))
				{
					this.Ongrp_subjectChanging(value);
					this.SendPropertyChanging();
					this._grp_subject = value;
					this.SendPropertyChanged("grp_subject");
					this.Ongrp_subjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grp_userName", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string grp_userName
		{
			get
			{
				return this._grp_userName;
			}
			set
			{
				if ((this._grp_userName != value))
				{
					this.Ongrp_userNameChanging(value);
					this.SendPropertyChanging();
					this._grp_userName = value;
					this.SendPropertyChanged("grp_userName");
					this.Ongrp_userNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_groupMember")]
	public partial class tb_groupMember : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _grpm_serial;
		
		private string _grpm_stdName;
		
		private string _grpm_stdId;
		
		private string _grpm_section;
		
		private string _grpm_stdPart;
		
		private System.Nullable<int> _grpm_stdMark;
		
		private string _grpm_groupNumber;
		
		private string _grpm_subject;
		
		private string _grpm_semester;
		
		private string _grpm_username;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ongrpm_serialChanging(int value);
    partial void Ongrpm_serialChanged();
    partial void Ongrpm_stdNameChanging(string value);
    partial void Ongrpm_stdNameChanged();
    partial void Ongrpm_stdIdChanging(string value);
    partial void Ongrpm_stdIdChanged();
    partial void Ongrpm_sectionChanging(string value);
    partial void Ongrpm_sectionChanged();
    partial void Ongrpm_stdPartChanging(string value);
    partial void Ongrpm_stdPartChanged();
    partial void Ongrpm_stdMarkChanging(System.Nullable<int> value);
    partial void Ongrpm_stdMarkChanged();
    partial void Ongrpm_groupNumberChanging(string value);
    partial void Ongrpm_groupNumberChanged();
    partial void Ongrpm_subjectChanging(string value);
    partial void Ongrpm_subjectChanged();
    partial void Ongrpm_semesterChanging(string value);
    partial void Ongrpm_semesterChanged();
    partial void Ongrpm_usernameChanging(string value);
    partial void Ongrpm_usernameChanged();
    #endregion
		
		public tb_groupMember()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_serial", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int grpm_serial
		{
			get
			{
				return this._grpm_serial;
			}
			set
			{
				if ((this._grpm_serial != value))
				{
					this.Ongrpm_serialChanging(value);
					this.SendPropertyChanging();
					this._grpm_serial = value;
					this.SendPropertyChanged("grpm_serial");
					this.Ongrpm_serialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_stdName", DbType="VarChar(150)")]
		public string grpm_stdName
		{
			get
			{
				return this._grpm_stdName;
			}
			set
			{
				if ((this._grpm_stdName != value))
				{
					this.Ongrpm_stdNameChanging(value);
					this.SendPropertyChanging();
					this._grpm_stdName = value;
					this.SendPropertyChanged("grpm_stdName");
					this.Ongrpm_stdNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_stdId", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string grpm_stdId
		{
			get
			{
				return this._grpm_stdId;
			}
			set
			{
				if ((this._grpm_stdId != value))
				{
					this.Ongrpm_stdIdChanging(value);
					this.SendPropertyChanging();
					this._grpm_stdId = value;
					this.SendPropertyChanged("grpm_stdId");
					this.Ongrpm_stdIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_section", DbType="VarChar(50)")]
		public string grpm_section
		{
			get
			{
				return this._grpm_section;
			}
			set
			{
				if ((this._grpm_section != value))
				{
					this.Ongrpm_sectionChanging(value);
					this.SendPropertyChanging();
					this._grpm_section = value;
					this.SendPropertyChanged("grpm_section");
					this.Ongrpm_sectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_stdPart", DbType="VarChar(150)")]
		public string grpm_stdPart
		{
			get
			{
				return this._grpm_stdPart;
			}
			set
			{
				if ((this._grpm_stdPart != value))
				{
					this.Ongrpm_stdPartChanging(value);
					this.SendPropertyChanging();
					this._grpm_stdPart = value;
					this.SendPropertyChanged("grpm_stdPart");
					this.Ongrpm_stdPartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_stdMark", DbType="Int")]
		public System.Nullable<int> grpm_stdMark
		{
			get
			{
				return this._grpm_stdMark;
			}
			set
			{
				if ((this._grpm_stdMark != value))
				{
					this.Ongrpm_stdMarkChanging(value);
					this.SendPropertyChanging();
					this._grpm_stdMark = value;
					this.SendPropertyChanged("grpm_stdMark");
					this.Ongrpm_stdMarkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_groupNumber", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string grpm_groupNumber
		{
			get
			{
				return this._grpm_groupNumber;
			}
			set
			{
				if ((this._grpm_groupNumber != value))
				{
					this.Ongrpm_groupNumberChanging(value);
					this.SendPropertyChanging();
					this._grpm_groupNumber = value;
					this.SendPropertyChanged("grpm_groupNumber");
					this.Ongrpm_groupNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_subject", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string grpm_subject
		{
			get
			{
				return this._grpm_subject;
			}
			set
			{
				if ((this._grpm_subject != value))
				{
					this.Ongrpm_subjectChanging(value);
					this.SendPropertyChanging();
					this._grpm_subject = value;
					this.SendPropertyChanged("grpm_subject");
					this.Ongrpm_subjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_semester", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string grpm_semester
		{
			get
			{
				return this._grpm_semester;
			}
			set
			{
				if ((this._grpm_semester != value))
				{
					this.Ongrpm_semesterChanging(value);
					this.SendPropertyChanging();
					this._grpm_semester = value;
					this.SendPropertyChanged("grpm_semester");
					this.Ongrpm_semesterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grpm_username", DbType="VarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string grpm_username
		{
			get
			{
				return this._grpm_username;
			}
			set
			{
				if ((this._grpm_username != value))
				{
					this.Ongrpm_usernameChanging(value);
					this.SendPropertyChanging();
					this._grpm_username = value;
					this.SendPropertyChanged("grpm_username");
					this.Ongrpm_usernameChanged();
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
