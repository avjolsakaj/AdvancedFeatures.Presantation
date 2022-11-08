using NUnit.Framework;

namespace AdvancedFeaturesCoding.Exercise25.Tests
{
    public class Tests
    {
        private List<string>? _filenames;
        private ImageFile? fileimages;
        private List<string>? _filenamesimg;

        [SetUp]
        public void Setup ()
        {
            _filenames = new List<string>();
            _filenames.Add("C:\\Users\\Hp\\Desktop\\photo\\Maksi.txt");
            fileimages = new ImageFile();
            _filenamesimg = new List<string>();
            _filenamesimg.Add("C:\\Users\\Hp\\Desktop\\photo\\Acm.png");
            _filenamesimg.Add("C:\\Users\\Hp\\Desktop\\photo\\download (1).jpg");
            _filenamesimg.Add("C:\\Users\\Hp\\Desktop\\photo\\RM.png");
            _filenamesimg.Add("C:\\Users\\Hp\\Desktop\\photo\\Tat.png");
            _filenamesimg.Add("C:\\Users\\Hp\\Desktop\\photo\\Syt\\download.jpg");
            _filenamesimg.Add("C:\\Users\\Hp\\Desktop\\photo\\Syt\\qtellcasin.png");
        }

        [TearDown]
        public void TearDown ()
        {
            _filenames.Clear();
            _filenamesimg.Clear();
            fileimages = null;
        }

        [Test]
        public void GetFileTxt ()
        {
            var result = fileimages.ImageList();
            Assert.AreNotEqual(result, _filenames);
        }

        [Test]
        public void GetFileImg ()
        {
            var result = fileimages.ImageList();
            Assert.AreEqual(result, _filenamesimg);
        }

        [Test]
        public void GetFirstPath ()
        {
            var result = fileimages.ImageList().First();
            Assert.AreEqual(result, "C:\\Users\\Hp\\Desktop\\photo\\Acm.png");
        }

        [Test]
        public void GetLastPath ()
        {
            var result = fileimages.ImageList().Last();
            Assert.AreEqual(result, "C:\\Users\\Hp\\Desktop\\photo\\Syt\\qtellcasin.png");
        }

    }
}
