using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBPayTrace
{
    public partial class frmMain : Form
    {
        // Constants are defined/populated in class Globlas
        // Username, password, Id's...

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //dtInvoiceDate.Text = DateTime.Now();
        }

        private void btnProcessInvoices_Click(object sender, EventArgs e)
        {
            // Get a token
            OAuthToken accessToken = GetToken();

            if (accessToken.ErrorFlag == false)
            {
                // Got a token
                txtAccessToken.Text = accessToken.AccessToken;

                // Download invoices to pay for selected date
                GetInvoicesForTheDay();


                // Loop through invoices to be paid and pay

                // 
            }
            else
            {
                // Couldn't get a token, exiting routine
                txtAccessToken.Text = "";
                MessageBox.Show("Http Status Code & Description : " + accessToken.ObjError.HttpTokenError + "\n API Error : " + accessToken.ObjError.Error + "\n API Error Message : " + accessToken.ObjError.ErrorDescription);
            }
        }

        private void cmdGetToken_Click(object sender, EventArgs e)
        {
            OAuthToken accessToken = GetToken();

            if (accessToken.ErrorFlag == false)
                txtAccessToken.Text = accessToken.AccessToken;
            else
            {
                // Error for OAuth
                txtAccessToken.Text = "";
                MessageBox.Show("Http Status Code & Description : " + accessToken.ObjError.HttpTokenError + "\n API Error : " + accessToken.ObjError.Error + "\n API Error Message : " + accessToken.ObjError.ErrorDescription);
            }
        }

        public OAuthToken GetToken()
        {
            Cursor.Current = Cursors.WaitCursor;

            OAuthToken PayTraceOAuthToken = GetPayTraceOAuthToken();

            Cursor.Current = Cursors.Default;

            return PayTraceOAuthToken;
        }

        private OAuthToken GetPayTraceOAuthToken()
        {
            OAuthTokenGenerator tokenGenerator = new OAuthTokenGenerator();

            OAuthToken OAuthResult = tokenGenerator.GetToken();

            string OAuth = String.Format("Bearer {0}", OAuthResult.AccessToken);

            return OAuthResult;
        }

        private void cmdGetInvoicesForTheDay_Click(object sender, EventArgs e)
        {
            GetInvoicesForTheDay();
        }

        private void GetInvoicesForTheDay()
        {
            string strLocation = "";

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                strLocation = "GIFTD1.0";
                string strSQL = "";
                strSQL = strSQL + "SELECT InvoiceHeader.CUST_NUM, InvoiceHeader.INV_NUMBER, InvoiceHeader.SUBTOTAL, InvoiceHeader.TAX_MON, InvoiceHeader.INV_TOTAL, InvoiceHeader.CHANGE_MEMO, ";
                strSQL = strSQL + "CustomerDepartment.DEL_NAME, InvoiceHeader.DATE ";
                strSQL = strSQL + "FROM InvoiceHeader ";
                strSQL = strSQL + "InvoiceHeader LEFT OUTER JOIN CustomerDepartment CustomerDepartment ON((InvoiceHeader.CUST_NUM= CustomerDepartment.CUST_NUM) ";
                strSQL = strSQL + "AND (InvoiceHeader.DEPT = CustomerDepartment.DEPT)) AND(InvoiceHeader.TAX_LOCODE = CustomerDepartment.TAX_LOCODE) ";
                strSQL = strSQL + "WHERE InvoiceHeader.DATE = '6/8/2022' ";
                strSQL = strSQL + "ORDER BY InvoiceHeader.INV_NUMBER ";

                using (SqlConnection conn = new SqlConnection(Globals.CS))
                {
                    strLocation = "GIFTD2.0";
                    conn.Open();

                    strLocation = "GIFTD3.0";
                    SqlDataAdapter da = new SqlDataAdapter();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = strSQL;
                    da.SelectCommand = cmd;

                    DataSet ds = new DataSet();

                    da.Fill(ds);

                    grdCustomers.DataSource = ds.Tables[0];

                    //SqlDataReader dataReader = cmd.ExecuteReader();

                    //while (dataReader.Read())
                    //{
                    //    MessageBox.Show("Cust_Num: " + dataReader["CUST_NUM"]);
                    //}
                }
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(this, $"Error in routine GetInvoicesForTheDay ({strLocation})\r\nError : {ex.Message}", "GetInvoicesForTheDay", MessageBoxButtons.OK);
            }
        }


        private void btnDownloadCustomers_Click(object sender, EventArgs e)
        {
            // Get a token
            OAuthToken accessToken = GetToken();

            if (accessToken.ErrorFlag == false)
            {
                // Got a token
                //string OAuth = String.Format("Bearer {0}", accessToken.AccessToken);
                string OAuth = accessToken.AccessToken;

                txtAccessToken.Text = OAuth;

                // Create dataset for request
                DownloadCustomersRequest downloadCustomersRequest = new DownloadCustomersRequest();
                downloadCustomersRequest.integrator_id = Globals.intergratorID;

                //converting request into JSON string
                var requestJSON = JsonSerializer.GetSeralizedString(downloadCustomersRequest);

                //call for actual request and response
                var payTraceResponse = new PayTraceResponse();
                var tempResponse = payTraceResponse.ProcessTransaction("/v1/customer/export", OAuth, requestJSON);

                //Create and assign the deseralized object to appropriate response type
                var createCustomerProfileResponse = new CreateCustomerProfileResponse();
                //createCustomerProfileResponse = JsonSerializer.DeserializeResponse<CreateCustomerProfileResponse>(tempResponse);

                //Assign the http error if any
                JsonSerializer.AssignError(tempResponse, (PayTraceBasicResponse)createCustomerProfileResponse);

            }
            else
            {
                // Couldn't get a token, exiting routine
                txtAccessToken.Text = "";
                MessageBox.Show("Http Status Code & Description : " + accessToken.ObjError.HttpTokenError + "\n API Error : " + accessToken.ObjError.Error + "\n API Error Message : " + accessToken.ObjError.ErrorDescription);
            }

        }
    }
}
