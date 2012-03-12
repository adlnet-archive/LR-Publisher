using System;
using System.Collections;
using System.Linq;
using Gtk;


[System.ComponentModel.ToolboxItem(true)]
public partial class CsvToLrMapRow : Gtk.Bin
{
    public const string NO_VAL_TEXT = "Select Column...";
    public const string CONSTANT_VAL_TEXT = "<Constant Value>";
    public const string ROW_AS_CSV_TEXT = "<Entire Row (as JSON)>";
	
	public readonly string [] RESOURCE_DATA_TYPES = {"resource", "paradata", "metadata", "assertion"};
	public readonly string [] IDENTITY_SUBMITTER_TYPES = {"anonymous", "user", "agent"};
	public readonly string [] PAYLOAD_PLACEMENTS = {"inline", "linked", "attached"};
	
	public string Key
	{
		get { return this.lbl_ResourceDataField.Text; }
	}
	
	private bool _isConstant;
	public bool IsConstant { get { return _isConstant; } }

    private bool _hasConstantValues;
    public bool HasConstantValues { get { return _hasConstantValues; } }

    private bool _isSerializeToRow;
    public bool IsSerializeToRow { get { return _isSerializeToRow; } }

    private IEnumerable _options;

	public string DropDownValue 
	{
		get
		{
			//TODO: improve exception throwing/handling for empty columns
            if (ColumnOptionsComboBox.Active == 0)
                    return null;
               return ColumnOptionsComboBox.ActiveText;
			
		}
	}

    public string ConstantValue
    {
        get { return this.CustomValueEntry.Text; }
    }

	public CsvToLrMapRow (IEnumerable options, string resourceDataDescriptionField)
	{
		this.Build ();
		
		ColumnOptionsComboBox.AppendText(NO_VAL_TEXT);
		
		//Add static options for fields that only have certain inputs
		if (resourceDataDescriptionField.Equals("*resource_data_type")){
			foreach(string type in RESOURCE_DATA_TYPES)
				this.ColumnOptionsComboBox.AppendText(type);
			_options = RESOURCE_DATA_TYPES;
		}
		else if(resourceDataDescriptionField.Equals("*identity.submitter_type")){
			foreach(string type in IDENTITY_SUBMITTER_TYPES)
				this.ColumnOptionsComboBox.AppendText(type);
			_options = IDENTITY_SUBMITTER_TYPES;
        }
		else if(resourceDataDescriptionField.Equals("*payload_placement")){
			foreach(string placement in PAYLOAD_PLACEMENTS)
				this.ColumnOptionsComboBox.AppendText(placement);
			_options = PAYLOAD_PLACEMENTS;
        }
		else{	
			foreach(string option in options)
				this.ColumnOptionsComboBox.AppendText(option);
        	_options = options;
			ColumnOptionsComboBox.AppendText(CONSTANT_VAL_TEXT);
        	ColumnOptionsComboBox.AppendText(ROW_AS_CSV_TEXT);
		}
		
		ColumnOptionsComboBox.Active = 0;
		
		this.lbl_ResourceDataField.Text = resourceDataDescriptionField;
		CustomValueEntry.Shown += OnColumnSelectionChanged;
	}

	protected void OnColumnSelectionChanged (object sender, System.EventArgs e)
	{
        if (ColumnOptionsComboBox.ActiveText == CONSTANT_VAL_TEXT)
		{
            CustomValueEntry.Visible = true;
            _isConstant = true;
		}
        else if(Key.Equals("*resource_data_type") || Key.Equals("*identity.submitter_type") || Key.Equals("*payload_placement"))
        {
            if (CustomValueEntry.Visible)
                CustomValueEntry.Visible = false;

            _hasConstantValues = true;
        }
		else
		{
            _isSerializeToRow = ColumnOptionsComboBox.ActiveText == ROW_AS_CSV_TEXT;

			if (CustomValueEntry.Visible)
				CustomValueEntry.Visible = false;

			_isConstant = false;
		}
	}
}


