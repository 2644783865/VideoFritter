﻿using System;

namespace VideoFritter.Common
{
    internal class AbstractExportingViewModel : AbstractViewModelBase, IProgress<double>
    {
        public bool IsExporting
        {
            get
            {
                return this.isExporting;
            }

            protected set
            {
                if (this.isExporting != value)
                {
                    this.isExporting = value;
                    OnPropertyChanged();
                }
            }
        }

        public double ExportProgress
        {
            get
            {
                return this.exportProgress;
            }

            protected set
            {
                if (this.exportProgress != value)
                {
                    this.exportProgress = value;
                    OnPropertyChanged();
                }
            }
        }

        void IProgress<double>.Report(double value)
        {
            ExportProgress = value;
        }

        private bool isExporting;
        private double exportProgress;

    }
}