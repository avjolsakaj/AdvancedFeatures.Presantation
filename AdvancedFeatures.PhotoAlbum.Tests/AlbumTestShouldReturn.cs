using AdvancedFeatues.PhotoAlbum;

namespace AdvancedFeatures.PhotoAlbum.Tests
{
    public class AlbumTestShouldReturn
    {
        private AdvancedFeatues.PhotoAlbum.PhotoAlbum _smallAlbum;
        private AdvancedFeatues.PhotoAlbum.PhotoAlbum _mediumAlbum;
        private BigPhotoAlbum _bigAlbum;

        [SetUp]
        public void Setup ()
        {
            _smallAlbum = new AdvancedFeatues.PhotoAlbum.PhotoAlbum();
            _mediumAlbum = new AdvancedFeatues.PhotoAlbum.PhotoAlbum(24, "Medium Album");
            _bigAlbum = new BigPhotoAlbum("Big Album");

        }

        [TearDown]
        public void TearDown ()
        {
            _smallAlbum = null;
            _mediumAlbum = null;
            _bigAlbum = null;
        }

        [Test]
        public void SmallAlbum_NumberOfPages ()
        {
            Assert.That(_smallAlbum.GetNumberOfPages(), Is.EqualTo(16));
        }

        [Test]
        public void MediumAlbum_NumberOfPages ()
        {
            Assert.That(_mediumAlbum.GetNumberOfPages(), Is.EqualTo(24));
        }

        [Test]
        public void LargAlbum_NumberOfPages ()
        {
            Assert.That(_bigAlbum.GetNumberOfPages(), Is.EqualTo(64));
        }

        [Test]
        public void SmallAlbum_Name ()
        {
            Assert.That(_smallAlbum.GetName(), Is.EqualTo("Small Album"));
        }

        [Test]
        public void MediumAlbum_Name ()
        {
            Assert.That(_mediumAlbum.GetName(), Is.EqualTo("Medium Album"));
        }

        [Test]
        public void LargAlbum_Name ()
        {
            Assert.That(_bigAlbum.GetName(), Is.EqualTo("Big Album"));
        }
    }
}