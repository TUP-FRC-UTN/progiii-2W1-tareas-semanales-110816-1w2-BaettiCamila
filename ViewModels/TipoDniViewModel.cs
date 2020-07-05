using System;

public class TipoDniViewModel
{
	private int idTipoDocumento;
	private String TipoDocumento;

	public int pidTipoDocumento {
		set { idTipoDocumento = value; }
		get { return idTipoDocumento; }
	}
	public String TipoDocumento { 
		set { TipoDocumento = value; }
        get { return TipoDocumento;  }
	}


	public TipoDniViewModel()
	{

		
	}
}
