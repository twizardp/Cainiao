using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cainiao.UI.UserControls
{
    public partial class UPager : UserControl
    {
        public UPager()
        {
            InitializeComponent();
        }

        public delegate void PageHandler(object sender, EventArgs e);
        public event PageHandler PageChange;

        private int record = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        public int Record
        {
            get { return record; }
            set { record = value; }
        }

        private int startIndex = 1;
        /// <summary>
        /// 开始索引
        /// </summary>
        public int StartIndex
        {
            get { return ((CurrentPage - 1) * PageSize) + 1; }
            set { startIndex = value; }
        }

        private int currentPage;
        /// <summary>
        /// 当前页
        /// </summary>
        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }


        private int pageSize = 10;
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private int pageNumber = 0;
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageNumber
        {
            get
            {
                if (Record == 0)
                {
                    pageNumber = 0;
                }
                else
                {
                    if (Record % PageSize > 0)
                    {
                        pageNumber = (Record / PageSize) + 1;
                    }
                    else
                    {
                        pageNumber = Record % PageSize;
                    }
                }

                return pageNumber;
            }
        }

        private void UPager_Load(object sender, EventArgs e)
        {

        }

        private void OnPageChanged()
        {
            PageChange?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// 刷新分页空间
        /// </summary>
        private void InitPageInfo()
        {

        }
    }
}
