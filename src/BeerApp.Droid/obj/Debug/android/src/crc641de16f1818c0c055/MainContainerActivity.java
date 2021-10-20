package crc641de16f1818c0c055;


public class MainContainerActivity
	extends crc6465b117471a9cc96e.BaseActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("BeerApp.Droid.Views.Main.MainContainerActivity, BeerApp.Droid", MainContainerActivity.class, __md_methods);
	}


	public MainContainerActivity ()
	{
		super ();
		if (getClass () == MainContainerActivity.class)
			mono.android.TypeManager.Activate ("BeerApp.Droid.Views.Main.MainContainerActivity, BeerApp.Droid", "", this, new java.lang.Object[] {  });
	}


	public MainContainerActivity (int p0)
	{
		super (p0);
		if (getClass () == MainContainerActivity.class)
			mono.android.TypeManager.Activate ("BeerApp.Droid.Views.Main.MainContainerActivity, BeerApp.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
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
