namespace electrodomesticosJaviPlus
{
    partial class almacen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label familiaLabel;
            System.Windows.Forms.Label precioLabel1;
            System.Windows.Forms.Label stockLabel1;
            System.Windows.Forms.Label idLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(almacen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox1 = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.familiaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button4 = new System.Windows.Forms.Button();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database3DataSet = new electrodomesticosJaviPlus.Database3DataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new electrodomesticosJaviPlus.Database3DataSetTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new electrodomesticosJaviPlus.Database3DataSetTableAdapters.TableAdapterManager();
            nombreLabel1 = new System.Windows.Forms.Label();
            familiaLabel = new System.Windows.Forms.Label();
            precioLabel1 = new System.Windows.Forms.Label();
            stockLabel1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(13, 56);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(47, 13);
            nombreLabel1.TabIndex = 8;
            nombreLabel1.Text = "Nombre:";
            // 
            // familiaLabel
            // 
            familiaLabel.AutoSize = true;
            familiaLabel.Location = new System.Drawing.Point(13, 91);
            familiaLabel.Name = "familiaLabel";
            familiaLabel.Size = new System.Drawing.Size(42, 13);
            familiaLabel.TabIndex = 9;
            familiaLabel.Text = "Familia:";
            // 
            // precioLabel1
            // 
            precioLabel1.AutoSize = true;
            precioLabel1.Location = new System.Drawing.Point(13, 127);
            precioLabel1.Name = "precioLabel1";
            precioLabel1.Size = new System.Drawing.Size(40, 13);
            precioLabel1.TabIndex = 10;
            precioLabel1.Text = "Precio:";
            // 
            // stockLabel1
            // 
            stockLabel1.AutoSize = true;
            stockLabel1.Location = new System.Drawing.Point(17, 167);
            stockLabel1.Name = "stockLabel1";
            stockLabel1.Size = new System.Drawing.Size(38, 13);
            stockLabel1.TabIndex = 11;
            stockLabel1.Text = "Stock:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(36, 209);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 11;
            idLabel1.Text = "Id:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 478);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.productoDataGridView);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(idLabel1);
            this.panel2.Controls.Add(stockLabel1);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(this.stockTextBox1);
            this.panel2.Controls.Add(precioLabel1);
            this.panel2.Controls.Add(this.precioTextBox);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(familiaLabel);
            this.panel2.Controls.Add(this.familiaTextBox);
            this.panel2.Controls.Add(nombreLabel1);
            this.panel2.Controls.Add(this.nombreTextBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(13, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 342);
            this.panel2.TabIndex = 0;
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToOrderColumns = true;
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(371, 3);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.Size = new System.Drawing.Size(376, 330);
            this.productoDataGridView.TabIndex = 2;
            this.productoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoDataGridView_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(66, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "MOSTRAR TABLA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(67, 206);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(280, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // stockTextBox1
            // 
            this.stockTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Stock", true));
            this.stockTextBox1.Location = new System.Drawing.Point(66, 167);
            this.stockTextBox1.Name = "stockTextBox1";
            this.stockTextBox1.Size = new System.Drawing.Size(280, 20);
            this.stockTextBox1.TabIndex = 12;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(67, 127);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(280, 20);
            this.precioTextBox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // familiaTextBox
            // 
            this.familiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Familia", true));
            this.familiaTextBox.Location = new System.Drawing.Point(66, 88);
            this.familiaTextBox.Name = "familiaTextBox";
            this.familiaTextBox.Size = new System.Drawing.Size(280, 20);
            this.familiaTextBox.TabIndex = 10;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(66, 53);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(280, 20);
            this.nombreTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productoBindingNavigatorSaveItem});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(790, 25);
            this.productoBindingNavigator.TabIndex = 1;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productoBindingNavigatorSaveItem
            // 
            this.productoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productoBindingNavigatorSaveItem.Image")));
            this.productoBindingNavigatorSaveItem.Name = "productoBindingNavigatorSaveItem";
            this.productoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.productoBindingNavigatorSaveItem.Click += new System.EventHandler(this.productoBindingNavigatorSaveItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(267, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 33);
            this.button4.TabIndex = 14;
            this.button4.Text = "INSERTAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.database3DataSet;
            // 
            // database3DataSet
            // 
            this.database3DataSet.DataSetName = "Database3DataSet";
            this.database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "Familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Familia";
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // database3DataSetBindingSource
            // 
            this.database3DataSetBindingSource.DataSource = this.database3DataSet;
            this.database3DataSetBindingSource.Position = 0;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.UpdateOrder = electrodomesticosJaviPlus.Database3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 474);
            this.Controls.Add(this.productoBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "almacen";
            this.Text = "almacen";
            this.Load += new System.EventHandler(this.almacen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Database3DataSet database3DataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Database3DataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private Database3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource database3DataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox stockTextBox1;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox familiaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}