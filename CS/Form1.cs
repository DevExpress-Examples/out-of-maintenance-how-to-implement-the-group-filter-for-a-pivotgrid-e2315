using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace HierarchicalFilters {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e) {
            this.pivotGridControl1.DataSource = GetTimeTableView();
            fieldMonth.CollapseAll();
        }
        void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            if (pivotGridControl1 == null) return;
            this.pivotGridControl1.BeginUpdate();
            PivotGridGroup group = this.pivotGridControl1.Groups[0];
            group.FilterValues.Reset();
            group.FilterValues.BeginUpdate();
            switch (radioGroup1.SelectedIndex) {
                case 0:
                    group.FilterValues.FilterType = PivotFilterType.Excluded;
                    break;
                case 1:
                    group.FilterValues.FilterType = PivotFilterType.Included;
                    group.FilterValues.Values.Add(2009).ChildValues.Add(12);
                    group.FilterValues.Values.Add(2010).ChildValues.Add(1);
                    break;
                case 2:
                    group.FilterValues.FilterType = PivotFilterType.Excluded;
                    group.FilterValues.Values.Add(2009);
                    break;
                case 3:
                    group.FilterValues.FilterType = PivotFilterType.Included;
                    SelectFirstDays(group);
                    break;
            }
            group.FilterValues.EndUpdate();
            this.pivotGridControl1.EndUpdate();
            if (radioGroup1.SelectedIndex == 3)
                fieldMonth.ExpandAll();
            else
                fieldMonth.CollapseAll();
        }
        void SelectFirstDays(PivotGridGroup group) {
            foreach(object year in group.GetUniqueValues(null)) {
                PivotGroupFilterValue value = group.FilterValues.Values.Add(year);
                foreach(object month in group.GetUniqueValues(new object[] { year })) {
                    value.ChildValues.Add(month).ChildValues.Add(1);
                }
            }
        }
    }
}