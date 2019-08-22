using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace App2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView txtNumber;
        EditText txtOperand1;
        EditText txtOperand2;
        TextView txtSum;
        int number;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            txtNumber = FindViewById<TextView>(Resource.Id.txtNumber);

            FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) =>
            txtNumber.Text = (++number).ToString();

            FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e) =>
            txtNumber.Text = (--number).ToString();

            txtSum = FindViewById<TextView>(Resource.Id.txtSum);
            txtOperand1 = FindViewById<EditText>(Resource.Id.operand1);
            txtOperand2 = FindViewById<EditText>(Resource.Id.operand2);

            FindViewById<Button>(Resource.Id.btnAdd).Click += (o, e) =>
            txtSum.Text = (int.Parse(txtOperand1.Text) - int.Parse(txtOperand2.Text)).ToString();
        }
    }
}