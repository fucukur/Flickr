package md5ba36dcacec47e5dbcde728e7698dc94c;


public class DataClass
	extends android.app.ListActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Appcent.DataClass, Appcent", DataClass.class, __md_methods);
	}


	public DataClass ()
	{
		super ();
		if (getClass () == DataClass.class)
			mono.android.TypeManager.Activate ("Appcent.DataClass, Appcent", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
