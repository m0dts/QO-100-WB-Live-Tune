# QO-100-WB-Quick-Tune

This Windows C# application grabs the fft data from the batc Wideband Spectrum monitor page and allows the user to click on signals which automatically configures Minitioune to the required settings to receive the signal via udp control.

You can control upto 4 receivers, just edit the minitioune ini file for each instance to use a different port.
No need to edit anything if you are just using one receiver.
If you have multiple receivers the area of the spectrum plot is split up and allows control of each receiver by clicking on the appropriate area which is shown by a grey box.

Various parts of the code come from the batc page javascript here: https://eshail.batc.org.uk/wb/

A pre-compiled version is included in the releases tab.

If you are running Windows 8.1 and get errors when the program starts you may need to upgrade the Dot Net framework, download V4.8 here: https://go.microsoft.com/fwlink/?LinkId=2088632
