package crc640cc0c108f342be42;


public class MainActivity_DatabaseService_Android
	extends android.app.Service
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBind:(Landroid/content/Intent;)Landroid/os/IBinder;:GetOnBind_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("teste_app.Droid.MainActivity+DatabaseService_Android, teste_app.Android", MainActivity_DatabaseService_Android.class, __md_methods);
	}


	public MainActivity_DatabaseService_Android ()
	{
		super ();
		if (getClass () == MainActivity_DatabaseService_Android.class) {
			mono.android.TypeManager.Activate ("teste_app.Droid.MainActivity+DatabaseService_Android, teste_app.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public android.os.IBinder onBind (android.content.Intent p0)
	{
		return n_onBind (p0);
	}

	private native android.os.IBinder n_onBind (android.content.Intent p0);

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
