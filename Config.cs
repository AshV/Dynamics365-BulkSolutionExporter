﻿
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Configuration
{

    private ConfigurationExportSolutionRequest[] exportSolutionRequestField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ExportSolutionRequest")]
    public ConfigurationExportSolutionRequest[] ExportSolutionRequest
    {
        get
        {
            return this.exportSolutionRequestField;
        }
        set
        {
            this.exportSolutionRequestField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ConfigurationExportSolutionRequest
{

    private string solutionNameField;

    private bool managedField;

    private bool exportAutoNumberingSettingsField;

    private bool exportCalendarSettingsField;

    private bool exportCustomizationSettingsField;

    private bool exportEmailTrackingSettingsField;

    private bool exportExternalApplicationsField;

    private bool exportGeneralSettingsField;

    private bool exportIsvConfigField;

    private bool exportMarketingSettingsField;

    private bool exportOutlookSynchronizationSettingsField;

    private string exportRelationshipRolesField;

    private bool exportSalesField;

    private string targetVersionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SolutionName
    {
        get
        {
            return this.solutionNameField;
        }
        set
        {
            this.solutionNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Managed
    {
        get
        {
            return this.managedField;
        }
        set
        {
            this.managedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportAutoNumberingSettings
    {
        get
        {
            return this.exportAutoNumberingSettingsField;
        }
        set
        {
            this.exportAutoNumberingSettingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportCalendarSettings
    {
        get
        {
            return this.exportCalendarSettingsField;
        }
        set
        {
            this.exportCalendarSettingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportCustomizationSettings
    {
        get
        {
            return this.exportCustomizationSettingsField;
        }
        set
        {
            this.exportCustomizationSettingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportEmailTrackingSettings
    {
        get
        {
            return this.exportEmailTrackingSettingsField;
        }
        set
        {
            this.exportEmailTrackingSettingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportExternalApplications
    {
        get
        {
            return this.exportExternalApplicationsField;
        }
        set
        {
            this.exportExternalApplicationsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportGeneralSettings
    {
        get
        {
            return this.exportGeneralSettingsField;
        }
        set
        {
            this.exportGeneralSettingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportIsvConfig
    {
        get
        {
            return this.exportIsvConfigField;
        }
        set
        {
            this.exportIsvConfigField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportMarketingSettings
    {
        get
        {
            return this.exportMarketingSettingsField;
        }
        set
        {
            this.exportMarketingSettingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportOutlookSynchronizationSettings
    {
        get
        {
            return this.exportOutlookSynchronizationSettingsField;
        }
        set
        {
            this.exportOutlookSynchronizationSettingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ExportRelationshipRoles
    {
        get
        {
            return this.exportRelationshipRolesField;
        }
        set
        {
            this.exportRelationshipRolesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExportSales
    {
        get
        {
            return this.exportSalesField;
        }
        set
        {
            this.exportSalesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TargetVersion
    {
        get
        {
            return this.targetVersionField;
        }
        set
        {
            this.targetVersionField = value;
        }
    }
}

