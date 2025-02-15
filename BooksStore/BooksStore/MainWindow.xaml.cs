using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.ObjectModel;
using static System.Net.Mime.MediaTypeNames;
using OfficeOpenXml;

namespace BooksStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<BookRecord> records;
        private int lastItemId = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Book Store Application.";
            ClearInputFields();
            PopulateComboBox();
            records = new ObservableCollection<BookRecord>();
            dataGridview_datagrid.ItemsSource = records;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (bookName_textbox != null)
            {
                bookName_textbox.GotFocus += (s, ev) =>
                {
                    if (bookName_textbox.Text != "")
                    {
                        bookName_textbox.Text = "";
                    }
                };
            }

            if (authorName_textbox != null)
            {
                authorName_textbox.GotFocus += (s, ev) =>
                {
                    if (authorName_textbox.Text != "")
                    {
                        authorName_textbox.Text = "";
                    }
                };
            }
            if (bookQuantity_textbox != null)
            {
                bookQuantity_textbox.LostFocus += (s, ev) =>
                {
                    if (bookQuantity_textbox.Text != "" && price_textbox.Text != "")
                    {
                        float initial_price = float.Parse(bookQuantity_textbox.Text) * float.Parse(price_textbox.Text);
                        float vat_price = initial_price * 0.04f;
                        float total_price = total_price_calculation(bookQuantity_textbox.Text, price_textbox.Text );
                        total_textblock.Text = total_price.ToString();
                        vat_textbox.Text = vat_price.ToString();

                    }
                };
            }

        }
        private void ClearInputFields()
        {
            bookName_textbox.Text = "Enter book Name";
            authorName_textbox.Text = "Enter author Name";
            bookPurchase_date_textbox.Text = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy");
            price_textbox.Text = "";
            bookQuantity_textbox.Text = "";
            vat_textbox.IsReadOnly = true;
            //vat_textbox.Text = "";
            total_textblock.Text = "";  



        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void authorName_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void PopulateComboBox()
        {
            authorName_ComboBox.Items.Clear(); // Clear existing items if any
            authorName_ComboBox.Items.Add("Rokomari");
            authorName_ComboBox.Items.Add("ProthomAlo");
            authorName_ComboBox.Items.Add("Nazrul Publication");
            authorName_ComboBox.Items.Add("NRCBT Publication");
        }

        private void dataGridview_datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        // Button Click Event to Add a Record
        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Input validation
                string bookName = bookName_textbox.Text;
                if (string.IsNullOrWhiteSpace(bookName))
                {
                    MessageBox.Show("Book name cannot be empty.", "Validation Error");
                    return;
                }

                string authorName = authorName_textbox.Text;
                if (string.IsNullOrWhiteSpace(bookName) || string.IsNullOrWhiteSpace(authorName))
                {
                    MessageBox.Show("Book name cannot be empty.", "Validation Error");
                    return;
                }

                if (!int.TryParse(bookQuantity_textbox.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error");
                   // return;
                }

                if (!decimal.TryParse(price_textbox.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Please enter a valid price.", "Validation Error");
                    return;
                }

                string publicationsName = authorName_ComboBox.SelectedItem as string;


                if (authorName_ComboBox.SelectedItem == null)
                {
                    
                    MessageBox.Show("No Publications selected!", "Error");
                    return;

                }

                // Calculate total price
                float totalPrice  = total_price_calculation(bookQuantity_textbox.Text, price_textbox.Text);

                // Today Date
                string formattedDate = DateTime.Now.ToString("MM-dd-yyyy");
                DateTime created_date = DateTime.ParseExact(formattedDate, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);

                // Increase Item ID value 
                lastItemId++;
                if (lastItemId % 2 == 0)
                {
                    publicationsName = "Hasan Publication";
                }
                
                // Add a new record to the ObservableCollection
                records.Add(new BookRecord
                {
                    ItemID = lastItemId,
                    BookName = bookName,
                    AuthorName = authorName,
                    PublicationsName = publicationsName,
                    Quantity = quantity,
                    Price = price,
                    TotalPrice = totalPrice,
                    Created= created_date
                });

              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
    


        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            ClearInputFields();
        }

        private float total_price_calculation(string quantity, string price)
        {
            float initial_price = float.Parse(quantity) * float.Parse(price);
            float vat_price = initial_price * 0.04f;
            float total_price = initial_price + (initial_price * 0.04f);

            return total_price;

        }

        private void saveData_button_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                DefaultExt = ".csv",
                FileName = "saveFile"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;

                // Call the CSVHelper to save data
                CSVHelper.WriteToCsv(filePath, records, new[] { "ID", "Author", "Name","Publication", "Price", "Quantity", "Total Price", "Datee" });

                MessageBox.Show("Data successfully exported to CSV!", "Success");
            }
        }
    }
}
