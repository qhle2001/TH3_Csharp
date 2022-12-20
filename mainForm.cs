using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using _20520944_TH3.Model;
using _20520944_TH3.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace _20520944_TH3
{
    public partial class mainForm : Form
    {
        public static List<Music> love_music = new List<Music>();
        public static List<Music> history_music = new List<Music>();
        public static List<string> _playlist = new List<string>();
        public static List<class_playlist> name_song_in_playlist = new List<class_playlist>();
        public static List<class_history_music> history_music_play = new List<class_history_music>();
        Music musicout;
        public mainForm()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            panel2.Hide();
            panel1.BringToFront();
            Home uc = new Home(music, "Home");
            addUserControl(uc);


        }
        public mainForm(Music musicin)
        {
            InitializeComponent();
            musicout = musicin;
            pictureBox1.BackgroundImage = musicout.Image;
            lb_name.Text = musicout.Name;
            lb_singer.Text =  musicout.Singer;
        }

        public static List<Music> music = new List<Music>()
        {

            new Music("Sorry", Resources.Sorry__I_got_lost_in_your_eyes_again_KHY, "NHẠC KHÔNG LỜI", "KHY", "KHY", "Sorry, I got lost in your eyes again_KHY.mp3", "Không có lời"),
            new Music("Soak up the Sun", Resources.Soak_up_the_Sun, "NHẠC KHÔNG LỜI", "KHY", "KHY", "Soak up the Sun.mp3", "Không có lời"),
            new Music("Kiria", Resources.Kiria, "NHẠC KHÔNG LỜI", "Jin Oki", "Jin Oki, Alexis Ffrench", "Kiria.mp3", "Không có lời"),
            new Music("Illuminate", Resources.Illuminate, "NHẠC KHÔNG LỜI", "Armik Dashchi", "Armik Dashchi", "Illuminate.mp3", "Không có lời"),
            new Music("Let's Get Loud", Resources.Let_s_Get_Loud, "NHẠC KHÔNG LỜI", "Gloria Estefan, Kike", "Hauser", "Let's Get Loud.mp3", "Không có lời"),
            new Music("Akatsuki", Resources.Akatsuki, "NHẠC KHÔNG LỜI", "Nao Matsushita", "Nao Matsushita", "Akatsuki.mp3", "Không có lời"),
            new Music("Bad guy", Resources.Bad_guy, "NHẠC KHÔNG LỜI", "Billie Eilish, Finneas O'Connell", "Vitamin String Quartet", "bad guy.mp3", "Không có lời"),
            new Music("Đại Dương Lấp Lánh", Resources.Đại_Dương_Lấp_Lánh, "NHẠC KHÔNG LỜI", "Touliver", "Hoàng Rob", "Đại Dương Lấp Lánh.mp3", "Không có lời"),
            new Music("Shallow", Resources.Shallow, "NHẠC KHÔNG LỜI", "Stefani Germanotta, Anthony Rossomando, Mark Ronson, Andrew Wyatt", "2Cellos", "Shallow.mp3", "Không có lời"),
            new Music("Kohakuboshi", Resources.Kohakuboshi, "NHẠC KHÔNG LỜI", "Yoshinari Tokuoka, Takuya Miura", "DEPAPEPE", "Kohakuboshi.mp3", "Không có lời"),


            new Music("Ngã tư không đèn", Resources.Ngã_tư_không_đèn, "Indie", "Trang", "Trang, Khoa Vũ", "TRANG x KHOA VŨ - 'Ngã Tư Không Đèn' (OFFICIAL MUSIC VIDEO).mp3", "Hẹn nhau lúc bốn giờ\r\nCà phê góc phố quen khi nắng ươm vàng\r\nLòng em như một giấc chiêm bao, vẫn đang dở dang\r\nHẹn nhau lúc bốn giờ\r\nVà anh luôn sớm hơn em, không chút vội vàng\r\nEm sẽ nói vì phố quá đông khiến em thở than\r\nTình yêu ta cứ như ngã tư không đèn\r\nNgười lại qua, chẳng thể biết ta nên dừng lại hay đi tiếp\r\nCứ như thói quen, ta thường nhìn nhau trong nghi vấn\r\nTình yêu sao cứ như ngã tư không đèn\r\nChẳng ai hay, thế nên chúng ta thôi đừng bàn chuyện tương lai\r\nCứ vui với nhau bây giờ cũng đâu có sai\r\nHẹn nhau lúc bốn giờ\r\nNhiều khi chẳng để nói nhau câu gì\r\nCùng nhau ngắm nhìn những lung linh cuối nơi hoàng hôn\r\nVà rồi tới chín giờ\r\nThì em cũng muốn anh đưa em tới nhà\r\nNgập ngừng nơi hè phố vắng tanh, anh có muốn\r\nTình yêu ta cứ như ngã tư không đèn\r\nNgười lại qua, chẳng thể biết ta nên dừng lại hay đi tiếp\r\nCứ như thói quen, ta thường nhìn nhau trong nghi vấn\r\nTình yêu sao cứ như ngã tư không đèn\r\nChẳng ai hay, thế nên chúng ta thôi đừng bàn chuyện tương lai\r\nCứ vui với nhau bây giờ cũng đâu có sai\r\nTình yêu ta cứ như ngã tư không đèn\r\nNgười lại qua, chẳng thể biết ta nên dừng lại hay đi tiếp\r\nCứ như thói quen, ta thường nhìn nhau trong nghi vấn\r\nTình yêu sao cứ như ngã tư không đèn\r\nChẳng ai hay, thế nên chúng ta thôi đừng bàn chuyện tương lai (thế nên chúng ta thôi đừng)\r\nCứ vui với nhau bây giờ cũng đâu có sai"),
            new Music("Mặt mộc", Resources.Mặt_mộc, "Indie", "Ân Nhi, Phạm Nguyên Ngọc", "PhạM Nguyên Ngọc, Vanh, Ân Nhi", "MẶT MỘC ｜ Phạm Nguyên Ngọc x VAnh x Ân Nhi (Original).mp3", "Không cần mang giày cao gót, không cần phấn son cầu kì\r\nMà khiến anh nằm mơ em đêm ngày\r\nBên cạnh em bình yên quá, anh chỉ muốn say mãi trong làn tóc thơm dịu dàng\r\nHay là anh gặp ba má xin được rước em về nhà\r\nĐể giữ em của riêng anh cả đời\r\nĐợi chờ anh đã lâu biết không, em muốn bên người\r\nChẳng tìm đâu ra một người như thế\r\nMôi cười xinh như hoa đáng yêu, thật thà\r\nCứ êm đềm thương nhau qua bao nắng mưa\r\nMột đời nâng niu, một đời đưa đón\r\nKhi bình minh ôm em ngủ say trong lòng\r\nĐến khi già nua vẫn say đắm em thôi\r\nAnh mang tâm tình gửi trọn vẹn vào từng lời ca\r\nNgượng ngùng nên khó nói ra cô gái của anh, em hiểu mà\r\nVới anh em là niềm vui\r\nVới anh em là tất cả\r\nLà chén rượu ngọt ngào nhất mà anh may mắn được thử qua\r\nAnh muốn được mang nụ cười em về cất ở trong nhà\r\nÁo kia sứt chỉ sờn vai có một người giúp anh chuyện may vá\r\nDẫu anh không đẹp vẫn có người gọi anh là soái ca\r\nLàm khùng làm điên rồi hai đứa nhìn nhau khà khà\r\nAnh đùa ấy\r\nAnh xin thề là anh đang nghiêm túc\r\nNghiêm túc muốn được vì em cả đời cố gắng mà không chịu khuất phục\r\nSẽ luôn là người đàn ông bên em khi vui hay khi em cáu\r\nĐời đi về đâu cũng được, miễn là hai đứa đi cùng nhau\r\nEm đồng ý em nhá\r\nMai anh qua thưa chuyện với mẹ cha\r\nBạn bè cô bác hai bên dắt tay hai đứa về chung một nhà\r\nTrời nắng hay trời mưa\r\nGiữa trưa hay là trời sập tối\r\nTrái tim này một lòng một dạ sẽ mãi chỉ hướng về em thôi\r\nMuốn tặng anh cả thế giới, anh lại nói anh chẳng mong gì\r\nChỉ muốn một vườn hoa sau sân nhà\r\nHay tặng em đời anh nhé, đêm ngày luôn săn sóc, nuông chiều lắng nghe mọi điều\r\nHay là anh gặp ba má nói rằng lỡ thương quá em rồi\r\nVì nhớ nhung ngày đêm anh bơ phờ\r\nTình yêu anh giản đơn, đã thương, thương đến vô bờ\r\nChẳng tìm đâu ra một người như thế\r\nMôi cười xinh như hoa đáng yêu, thật thà\r\nCứ êm đềm thương nhau qua bao nắng mưa\r\nMột đời nâng niu, một đời đưa đón\r\nKhi bình minh ôm em ngủ say trong lòng\r\nĐến khi già nua vẫn say đắm em thôi\r\nNgười đẹp như mây, một đời anh say\r\nAnh nguyện đưa em đi khắp nơi trên đời\r\nNgắm mây ngàn giăng giăng trên núi cao\r\nCuộc đời cho em thật nhiều may mắn\r\nKhi chạm môi anh em ngỡ như thiên đàng\r\nĐến khi già nua vẫn hôn mãi anh thôi\r\nĐến khi già nua vẫn say đắm em thôi"),
            new Music("Chết trong em", Resources.Chết_trong_em, "Indie", "Thịnh Suy", "Thịnh Suy", "Thịnh Suy - Chết Trong Em (Official Music Video).mp3", "Ở trong góc tường có tôi\r\nỞ nơi cuối đường có ai không\r\nĐời trôi quá dài mất em\r\nThời như đứng lại ngó xem tôi đang lặng im một mình\r\nÔm lấy hết cô đơn như trong đời ta\r\nHah\r\nChết trong tôi một phần tim thao thức\r\nChết trên môi một mùi hương chưa dứt\r\nChết theo em bầu trời sấm chớp mây đen\r\nChết trong em một niềm tin chôn giấu\r\nChết trong tôi một phần tim nung nấu\r\nChết trong đêm và tình mãi chết trong đêm\r\nTình như khúc nhạc xót xa\r\nTrong đêm tối lặng\r\nMắt ta đang nơi lặng im một mình\r\nÔm lấy hết cô đơn như trong đời ta\r\nHah\r\nChết trong tôi một phần tim thao thức\r\nChết trên môi một mùi hương chưa dứt\r\nChết theo em bầu trời sấm chớp mây đen\r\nChết trong em một niềm tin chôn giấu\r\nChết trong tôi một phần tim nung nấu\r\nChết trong đêm và tình mãi chết trong đêm\r\nHah hah hah hah\r\nHah hah hah hah"),
            new Music("Em thích", Resources.Em_thích, "Indie", "Sean", "Sean, Lửa", "EM THÍCH - SEAN X @Lửa Official  [OFFICIAL MV LYRIC].mp3", "Và nếu em thấy cô đơn, cô đơn\r\nAnh sẽ luôn ở đây vì\r\nAnh chẳng muốn công chúa của anh ướt mi\r\nLại đây để anh ôm\r\nAnh ôm em thật lâu nà\r\nAnh sẽ trao hết yêu thương\r\nĐể em quên mau\r\nHai giờ đêm anh vẫn còn nhớ\r\nNhững lúc ta trao nhau ngọt ngào\r\nPhải làm sao để giữ trái tim\r\nLuôn đong đầy mà không nhạt phai\r\nCho lòng anh mơ màng\r\nRồi rơi xuống đây\r\nLàm con tim anh đắm say\r\nChỉ muốn nắm tay người\r\nVà đi hết cuộc đời này\r\nVà nếu em thấy cô đơn cô đơn\r\nAnh sẽ luôn ở đây vì\r\nAnh chẳng muốn công chúa của anh ướt mi\r\nLại đây để anh ôm\r\nAnh ôm em thật lâu nà\r\nAnh sẽ trao hết yêu thương để em quên mau\r\nYeah yeah\r\nEm thích đi dạo phố trên tay cầm phô mai que\r\nRồi mở bài nhạc của anh bật max âm lượng kề vô tai nghe\r\nEm thích ăn cá viên chiên, em thích hồng trà sữa\r\nEm nói em mong sau này có một người chồng là Lửa\r\nEm thích anh sờ đầu em, cảm giác cute khó nói\r\nAnh hỏi em thương anh không lúc đó làm em khó chối\r\nEm thích được anh vếu má, rồi đặt nhẹ bờ môi lên\r\nEm cũng làm ngược lại, để cho cân đều đôi bên\r\nEm thích màu xanh màu đỏ, không thích màu hồng cánh sen\r\nEm nói là em có phép thuật winx thì anh đừng hòng đánh em\r\nEm thích tình yêu đơn giản, không thích nhiều điều phức tạp\r\nEm nói anh chính là nơi vững chắc cho em thật nhiều sức đạp\r\nEm thích xuống bếp nấu ăn, dở ẹc mà không dám nói\r\nCon cá đen thui thùi lùi ẩn mình ở trong đám khói\r\nEm thích ra biển cùng anh, không thích làm kẻ sea tình\r\nNếu mà hiểu được tính tình của em, kể ra cũng cả quy trình\r\nVà nếu em thấy cô đơn, cô đơn\r\nAnh sẽ luôn ở đây vì\r\nAnh chẳng muốn công chúa của anh ướt mi\r\nLại đây để anh ôm\r\nAnh ôm em thật lâu nà\r\nAnh sẽ trao hết yêu thương để em quên mau\r\nVà nếu em thấy cô đơn, cô đơn\r\nAnh chẳng muốn công chúa của anh ướt mi\r\nLại đây để anh ôm anh ôm\r\nAnh sẽ trao hết yêu thương để em quên mau"),
            new Music("Có em", Resources.Có_em, "Indie", "Madihu, Low G", "Madihu, Low G", "Madihu - Có em (Feat. Low G) [Official MV].mp3", "Từ ngày hôm qua khung trời bên cửa sổ đẹp lung linh bên ngàn tia nắng\r\nĐể ngày hôm nay khung trời riêng mang trong mình anh thêm em đến bên đời\r\nBởi vì khi nắng vẫn còn rơi\r\nKhi bóng tối còn chơi vơi\r\nKhi ánh mắt nghỉ ngơi\r\nThao thức tháng ngày trôi\r\nLà khi em đến giấc ngủ say\r\nThao thức bỗng chợt theo mây\r\nCuốn theo đơn côi biết bao ngày\r\nBecause now you are my bae\r\n'Cause you're now my bae\r\n'Cause you're now my bae\r\n'Cause you're now my babe\r\nBecause now you are my bae\r\n'Cause you're now my babe\r\n'Cause it's you, ooh-ooh-ooh\r\nLà bởi vì có em, mây thay màu\r\nĐẹp tựa bao giấc mơ chôn sâu anh từng giấu\r\nBởi vì là chính em mang u sầu\r\nGửi vào làn gió bay xa để khung trời anh giữ sẽ có thêm màu xanh\r\nOoh yeah, thấy em nhìn lướt khi vào show, biết ngay là cá đã cắn câu (xời)\r\nOoh yeah, có ngay cả squad đang nhìn thâu, anh đoán là không ai cưa được đâu (no)\r\nOoh yeah, baby girl anh xin số, xong anh khuyến mãi một lượt flow\r\nAnh đón em buổi sáng, em cho anh chờ lâu, xung quanh khu em nguyên một hàng dâu\r\nEm ra cười ngại, không nói một câu\r\nAnh bảo thoải mái đi với ai sao phải giấu\r\nTặng ngay cho em bông hoa mà trông xấu nhưng phải thế nó mới tôn khuôn mặt xinh của em, woah\r\nTặng em cà phê, cà phê pha\r\nEm thích bạc xỉu, tiền anh bún trả\r\nCảm thấy cá hồi đợt vừa rồi hơi suy, người anh như tá lả khi bồ cũ nó trà đá\r\nNên là lên Đà Lạt food tour cho nó chill đê, eh\r\nVisa lấy ra tiêu đê, eh\r\nEm bảo anh là yêu ghê\r\nBook con Airbnb nhìn thì siêu mê\r\nMặc ngay con áo phao xong đi ngắm sao\r\nVặn ga trên đồi xong rồi tán nhau\r\nSoi tướng phu thê mình có trán cao cùng quả môi dày tình cảm để cho chúng nó chạm nhau, eh\r\nBecause now you are my bae\r\n'Cause you're now my bae\r\n'Cause you're now my bae\r\n'Cause you're now my babe\r\nBecause now you are my bae\r\n'Cause you're now my babe\r\n'Cause it's you, ooh-ooh-ooh\r\nLà bởi vì có em, mây thay màu\r\nĐẹp tựa bao giấc mơ chôn sâu anh từng giấu\r\nBởi vì là chính em mang u sầu\r\nGửi vào làn gió bay xa để khung trời anh giữ sẽ có thêm màu xanh\r\nCó lẽ ngày mai khi đôi mắt đã dần phai phôi\r\nVẫn đưa theo ngàn mây chờ tia nắng phía bờ môi ấy\r\nKhẽ nắm bàn tay đang ôm tiếng nói của anh rất lâu, huh-ooh-ooh-oh\r\nThấp thoáng mùi hương vương trên mái tóc của em\r\nĐưa giấc mơ đang chìm sâu về bên nắng gió cùng lời ca\r\nGiấu tháng ngày bơ vơ trong ánh mắt mà em vẫn đang trao đến anh\r\nLà bởi vì có em, mây thay màu (có em)\r\nĐẹp tựa bao giấc mơ chôn sâu anh từng giấu (từng giấu, từng giấu)\r\nBởi vì là chính em mang u sầu (chính em, chính em)\r\nGửi vào làn gió bay xa để khung trời anh giữ sẽ có thêm màu xanh\r\nBecause now you're now my bae\r\n'Cause you're now my bae\r\n'Cause you're now my bae\r\n'Cause you're now my babe\r\nBecause now you're now my bae\r\n'Cause you're now my babe\r\n('Cause it's you) 'Cause you're now my bae (yeah, yeah)\r\n'Cause you're now my babe, eh, yeah-yeah\r\n"),
            new Music("Đôi mươi", Resources.Đôi_mươi, "Indie", "Hoàng Dũng", "Hoàng Dũng", "HOÀNG DŨNG - ĐÔI MƯƠI ｜ OFFICIAL MV ｜ EP 'YÊN' - 2⧸3.mp3", "Em hãy cứ lang thang dưới những tán cây\r\nHãy cứ gối lên đôi chân anh suốt ngày\r\nNếu muốn hát lên cho thêm huyên náo đâu cần phải ngó quanh (hmmm)\r\nVì trời đất kia là của chúng mình\r\nAnh sẽ nói yêu em từ ngày đến đêm\r\nSẽ vẫn đón đưa em dù đường sẽ xa thêm\r\nVứt hết những thói quen không quan trọng để an ủi em mỗi khi bất bình\r\nThời gian ấy của riêng chúng mình\r\nEm đẹp tựa như khúc ca\r\nMà anh vẫn ngân nga bên ô cửa đầy nắng ấm\r\nHãy đan tay giữa phố tan tầm\r\nVà ghi nhớ những tháng ngày mà ta đang yêu\r\nNhững ngày ta đôi mươi, những ngày ta rất vui\r\nNhững ngày em bên anh đưa tay ta hái sao trên bầu trời\r\nLời hứa ghi trên bờ môi, dẫu một mai thế giới kia ngừng trôi\r\nÔi những ngày mà ta đôi mươi\r\nDành tất cả nhiệt thành để yêu một người\r\nChẳng muốn nhớ về lời tỏ tình đánh rơi\r\nChẳng muốn đắn đo lý do em đáp lời\r\nChẳng muốn nghĩ xung quanh ai nghi vấn ta liệu có xứng đôi\r\nTa vẫn cứ yêu nhau đấy thôi\r\nVà nếu một ngày em lỡ quên\r\nNgày anh đứng bên hiên mưa tuôn chờ em bước tới\r\nSẽ ngân nga về em đôi lời\r\nVề năm tháng đẹp tươi mình từng bên nhau mãi không xa rời (hoh-uh-oh)\r\nNhững ngày ta đôi mươi, những ngày ta rất vui\r\nNhững ngày em bên anh đưa tay ta hái sao trên bầu trời\r\nLời hứa ghi trên bờ môi dẫu một mai thế giới kia ngừng trôi\r\nÔi những ngày mà ta đôi mươi\r\nDành tất cả nhiệt thành để yêu một người\r\nLa la la la\r\nLa la la la\r\nLa la la la\r\nAnh muốn sống mãi tuổi đôi mươi\r\nLa la la la\r\nLa la la la la\r\nLa la la la\r\nNhững ngày ta đôi mươi\r\nNhững ngày ta rất vui\r\nNhững ngày em bên anh đưa tay ta hái sao trên bầu trời\r\nLời hứa ghi trên bờ môi, dẫu một mai thế giới kia ngừng trôi\r\nÔi những ngày mà ta đôi mươi\r\nDành tất cả nhiệt thành để yêu một người\r\nLa la la la\r\nLa la la la\r\nLa la la la\r\nAnh muốn sống mãi tuổi đôi mươi\r\nLa la la la\r\nLa la la la la (uh-uh-uh)\r\nLa la la la\r\nAnh muốn sống mãi tuổi đôi mươi"),
            new Music("Quên đặt tên", Resources.Quên_đặt_tên, "Indie", "Phạm Nguyên Ngọc", "Phạm Nguyên Ngọc", "QUÊN ĐẶT TÊN ｜ Phạm Nguyên Ngọc (OFFICIAL MV).mp3", "Ngày ấy khi đôi mươi tôi đem lòng thương nhớ ai\r\nNgày ấy người ta nói sẽ quay về\r\nNgày ấy bão trong tim nhưng tôi chỉ biết đứng yên\r\nNgày ấy có cơn đau quên đặt tên\r\nLâu không gặp nhau\r\nLâu không chào nhau\r\nLâu không đôi lời\r\nMới đấy đã xa gần ba năm\r\nCái hôn ấy chưa khô\r\nGiọt nước mắt cũng chưa khô\r\nChỉ là yêu thương giờ xác xơ\r\nNăm tháng trôi phiêu diêu\r\nMộng mơ theo những cánh diều\r\nCó đâu ngờ\r\nTương tư mang theo mãi\r\nÔm khát khao riêng ta\r\nBuồn thay cơn bão đi qua\r\nNgười đi mất\r\nTim ơi đừng xót xa\r\nNgày ấy khi đôi mươi tôi đem lòng thương nhớ ai\r\nNgày ấy người ta nói sẽ quay về\r\nNgày ấy bão trong tim nhưng tôi chỉ biết đứng yên\r\nNgày ấy có cơn đau quên đặt tên\r\nHạ vắng kéo yêu thương trôi thật chậm đi rất xa\r\nThu kéo dấu yêu về vội vã\r\nDòng thư tình tôi viết riêng cho người gửi vào nắng\r\nBuồn thay người chỉ yêu những cơn mưa\r\nNgày ấy có cơn đau quên đặt tên\r\nCon nắng kia hơi to cơn mưa kia cũng hơi to\r\nChút vô tình mưa mang ai xa mất\r\nÔm khát khao riêng ta buồn thay cơn bão đi qua\r\nNgười đi mất tim ơi đừng xót xa\r\nNgày ấy khi đôi mươi tôi đem lòng thương nhớ ai\r\nNgày ấy người ta nói sẽ quay về\r\nNgày ấy bão trong tim nhưng tôi chỉ biết đứng yên\r\nNgày ấy có cơn đau quên đặt tên\r\nHạ vắng kéo yêu thương trôi thật chậm đi rất xa\r\nThu kéo dấu yêu về vội vã\r\nDòng thư tình tôi viết riêng cho người gửi vào nắng\r\nBuồn thay người chỉ yêu những cơn mưa\r\nNgày ấy có cơn đau quên đặt tên\r\nHạ vắng kéo yêu thương trôi thật chậm đi rất xa\r\nThu kéo dấu yêu về vội vã\r\nDòng thư tình tôi viết riêng cho người gửi vào nắng\r\nBuồn thay người chỉ yêu những cơn mưa\r\nNgày ấy có cơn đau quên đặt tên\r\n"),
            new Music("Giá như ta", Resources.Giá_như_ta, "Indie", "Tô Đông Phong, Muội", "Starry Night", "STARRY NIGHT - GIÁ NHƯ TA (OFFICIAL MUSIC VIDEO).mp3", "Một lần thôi\r\nĐôi tay em sẽ buông\r\nĐể người khác nắm chặt\r\nVết thương lành thật nhanh\r\nMột lần thôi\r\nNước mắt em sẽ rơi\r\nMột đêm cuối bên người\r\nĐể suốt đời cách xa\r\nCảm ơn anh đã bên em những ngày\r\nChẳng ai biết em ở đâu\r\nGiờ thì anh hãy, hãy quay trở về\r\nVề nơi ta vẫn chưa bắt đầu\r\nGiá như ta chẳng biết nhau vào ngày mưa lúc xưa\r\nGiá như anh chẳng đem lòng say đắm\r\nGiá như ta gặp nhau ngày anh chưa có ai\r\nThì tình ta đâu dễ phai\r\nNói em nghe, anh đã thương em thật lòng dẫu là\r\nChúng ta sai, chẳng ai được oán trách\r\nHứa đi anh, ngày mai chẳng còn ai thấy ai\r\nVề đi anh, người ta đang chờ\r\nMột lần thôi, nước mắt em sẽ rơi\r\nMột đêm cuối bên người để suốt đời cách xa\r\nCảm ơn anh đã bên em những ngày\r\nChẳng ai biết em ở đâu\r\nGiờ thì anh hãy, hãy quay trở về\r\nVề nơi ta vẫn chưa bắt đầu\r\nGiá như ta chẳng biết nhau vào ngày mưa lúc xưa\r\nGiá như anh chẳng đem lòng say đắm\r\nGiá như ta gặp nhau ngày anh chưa có ai\r\nThì tình ta đâu dễ phai\r\nNói em nghe, anh đã thương em thật lòng dẫu là\r\nChúng ta sai, chẳng ai được oán trách\r\nHứa đi anh, ngày mai chẳng còn ai thấy ai\r\nVề đi anh, người ta đang chờ\r\nHứa đi anh, ngày mai chẳng còn ai thấy ai\r\nVề đi anh, người ta đang chờ\r\nSource"),
            new Music("Thoáng qua", Resources.Thoáng_qua, "Indie", "Dư Quốc Vương", "Whee", "THOÁNG QUA - WHEE! (Official Music Video).mp3", "Verse 1\r\nTừng chiều gió đìu hiu\r\nBồn bề rất nhiều điều\r\nMùa hạ rét tựa đông\r\nÔi lạnh cóng!\r\n\r\nNhiều lần nhớ bàn tay\r\nVỗ về giấc ngủ say\r\nMà người có nào hay\r\nYêu người đắm say…\r\n\r\nChorus\r\nThoáng qua, chỉ là thoáng qua\r\nCuộc tình chúng ta\r\nĐi về nơi xa\r\nThoáng qua, chỉ là thoáng qua\r\nMột người lướt qua\r\nMột người xót xa.\r\n\r\nVerse 2\r\nTình cờ thấy được nhau\r\nTình cờ nhớ thật lâu\r\nGiờ người trốn ở đâu\r\nSao chẳng thấy?\r\n\r\nGiật mình hết hồn nhiên\r\nLòng đầy những muộn phiền\r\nVì chẳng có người yêu nên mình phát điên ☹\r\n\r\nChorus\r\nThoáng qua, chỉ là thoáng qua\r\nCuộc tình chúng ta\r\nĐã đi về nơi xa…xa mãi\r\nThoáng qua, chỉ là thoáng qua\r\nMột người lướt qua\r\nMột người xót xa\r\nMột người bước đi,\r\nMột người ướt mi…"),
            new Music("Em không khóc", Resources.Em_không_khóc, "Indie", "Bùi Trường Linh", "Bùi Trường Linh, Vũ Phụng Tiên", "Em Không Khóc ⧸ buitruonglinh ft vuphungtien.mp3", "Deep in my heart, I just don't wanna miss you\r\n'Cause all that was rude, I found myself tryin' to call you\r\nBroken inside, baby I've come to realize\r\nIt was just a game\r\nI was a deer, you were the hunter\r\nCứ bước thẳng vào trong, giống hệt thói quen mà không cần nghĩ ngợi\r\nNhư thể ở đây chỉ có một mình chẳng ai để ý tới\r\nLần nào cũng cô đơn như vậy vẫn còn muốn đợi\r\nCó lẽ bây giờ điều cần thiết nhất là một giấc nghỉ ngơi\r\nCó người uống không bỏ sót chẳng để lại dư giọt nào\r\nNhìn bộ dạng thì thứ họ rót không thể là thứ ngọt ngào\r\nChâm đốm lửa, một vài âm thanh khiến tôi phải đoán xem\r\nTiếng giày cao gót vừa bước vào, là cô ca sĩ ở quán quen\r\nẤy không, đấy không phải điều tôi hi vọng tối nay\r\nCó nhiều hơn một lý do khiến tôi phải ngồi trong xe để tới đây\r\nNhả khói bay, bartender hiểu tôi cần một dư vị đậm chất\r\nĐôi lúc thứ sâu đậm nhất lại khiến mình chẳng thể nói ngay\r\nNgắm nghía xung quanh một vòng sau lần chợp mắt bị dập tắt\r\nKhông cách quá xa ánh đèn nơi tôi cho rằng phù hợp nhất\r\nMột ngụm quên hết màn đêm thì còn trái tim nào chưa muốn mở\r\nĐặt xuống, nhìn em qua ly Dry Gin còn đang uống dở\r\nDeep in my heart, I just don't wanna miss you\r\n'Cause all that was rude, I found myself tryin' to call you\r\nBroken inside, baby I've come to realize\r\nIt was just a game\r\nI was a deer, you were the hunter\r\nMột người xinh như em sao lại ở đây giờ này nhỉ\r\nVẫn không phải điều bình thường cho dù tôi biết rằng mai là ngày nghỉ\r\nMiniskirt và ở bên dưới là một đôi Blazer Low\r\nEm vén mái tóc mình lại, buộc gọn nó ở ngay đằng sau\r\nUhm đúng rồi, tôi thích em trông mạnh mẽ thế này hơn\r\nKhi con người ta thường bị tổn thương bởi vài thứ giản đơn\r\nLà khi em không còn cảnh giác, thái độ bất cần cũng đã mất dần\r\nLà trong một khoảnh khắc, khoảng cách của tôi và em đã rất gần\r\nEm thất thần, nhìn lại ngay cái Hublot bên tay trái\r\nTôi cá là em không đủ tỉnh táo để biết được giờ là nửa đêm\r\nSoạn sửa thêm, em thả xuống cái túi xách hồi nãy vắt ngược lên vai\r\nLỡ say đến thế, miệng vẫn còn lẩm bẩm nhắc được tên ai\r\nĐôi mắt màu nâu sậm, chứa nỗi buồn sâu đậm\r\nLỡ đánh rơi vài viên thuốc mấy người bình thường nào đâu ngậm\r\nSân khấu đang hát từng câu chậm theo nhịp bước chân tôi đi tới\r\nCuối cùng thì đã đến lúc lại bên em và ngỏ lời\r\nAh, chào em (Chào anh nhá)\r\nAnh hôm nay đến hơi muộn nên phía bên kia vừa hết bàn í\r\nVừa hay còn một chỗ trống cạnh em\r\nKhông biết là anh có thể ngồi đây\r\nĐể nghe nốt buổi biểu diễn tối hôm nay được không?\r\nLý do bất khả kháng, nhưng nghe qua lại rất thoả đáng\r\nTôi vừa làm được một chuyện mấy gã bàn bên chắc phải vất vả chán\r\nCó khi mất cả tháng, mà nào có dịp nói đâu hả trời\r\nNhận câu trả lời khiến giai điệu kia một lần nữa toả sáng\r\nKhi mà đôi bên đã trải qua được những phút đầu cầm cự\r\nTôi chắc chắn là người đáng tin để em trút bầu tâm sự\r\nChuyện gia đình và những áp lực chưa một lần than thở\r\nMối tình mà em dốc hết tâm can, lúc này chỉ còn dang dở\r\nĐưa vội hai tay, che đi nỗi uất ức nghẹn trào\r\nEm bảo không khóc nhưng lời em nói cứ bị tiếng nấc chẹn vào\r\nTừ khi nào quãng đường em đi phải bước những bước nghẹn ngào\r\nNhư thể tuổi xuân vốn trôi qua chưa từng có lời ước hẹn nào\r\nLy rượu giờ đối với em cứ như điều ước đặt ở trước mặt\r\nNuốt hết niềm cay đắng, nuốt nước mắt mà chẳng cần bước ngoặt\r\nNhững niềm đau mà không mũi khâu nào ai vá nổi\r\nEm dần học cách để cho làn khói đi sâu vào hai lá phổi\r\nNhưng em ơi, em xứng đáng nhiều hơn những điều như thế\r\nAnh chắc là sẽ luôn có một nơi đang đợi em trở về\r\nĐừng lựa chọn lấy điều tiêu cực là thứ em nghĩ tới\r\nBuồn đau chẳng giống men rượu, em càng uống càng không cách gì vơi\r\nCòn cả một chặng đường dài chờ em phía trước kìa\r\nVẫn hãy cứ là mình, vẫn vui vẻ hồn nhiên như trước kia\r\nLúc mặt trời lên, khi bồ công anh khẽ chớm nở dại\r\nÁnh nắng kề bên, nụ cười trên môi em sẽ sớm trở lại\r\nNhư nhận ra những lời tôi nói, em mỉm cười không còn đẫm lệ\r\nVài người khách cuối cùng, đưa nhau đi chẳng hề chậm trễ\r\nChấm hết cho một ngày dài, khi cả em và nó đều ngã gục\r\nChắc là viên thuốc vừa nãy đánh tráo đã có tác dụng\r\nBước thẳng vào trong, giống hệt thói quen không cần nghĩ ngợi\r\nNhư thể ở đây chỉ có một mình chẳng ai để ý tới\r\nLần nào cũng cô đơn như vậy mà vẫn còn muốn đợi\r\nCó lẽ bây giờ điều cần thiết nhất, là một giấc nghỉ ngơi"),

            new Music("Rung động", Resources.Rung_động, "Acoustic", "Vũ Khắc Anh, Nguyễn Quang Long", "Dương Edward, Vũ Khắc Anh", "RUNGDONG - DƯƠNG EDWARD x VŨ KHẮC ANH [OFFICIAL MUSIC VIDEO].mp3", "Anh chẳng biết thế nào là yêu\r\nChỉ biết là mỗi khi không được nhìn em\r\nLòng lại dâng lên bao nhiêu cảm xúc thấy rất khó tả\r\nAnh nhớ em nhiều phải chăng đó chính là yêu\r\nBuồn vì em đau vui khi trên môi em nở nụ cười\r\nAnh muốn là người mang đến em bình yên\r\nEm có muốn cùng anh đi qua bao bão giông\r\nEm có muốn ở cạnh bên anh đến suốt đời\r\nMột thế giới riêng anh và em\r\nVới những niềm vui hạnh phúc đắm say\r\nAnh muốn là người chở che khi em yếu mềm\r\nAnh muốn được vòng tay ra ôm em mỗi đêm\r\nLiệu anh có thể là người em chọn sánh đôi\r\nVà anh đã yêu em từ lâu lắm\r\nPhút giây anh với em chạm mặt ngày ấy\r\nChỉ tựa như mây trôi ngang qua thôi\r\nNhưng lỡ thương rồi (nhưng lỡ thương rồi)\r\nAnh đã rung động chợt thấy thêm yêu cuộc sống\r\nĐừng buồn em ơi ngay bên em đã có dáng anh rồi (có dáng anh rồi)\r\nAnh sẽ là người mang đến cho em bình yên oh\r\nEm có muốn cùng anh đi qua bao bão giông\r\nEm có muốn ở cạnh bên anh đến suốt đời\r\nMột thế giới riêng anh và em\r\nVới những niềm vui hạnh phúc đắm say\r\nAnh muốn là người chở che khi em yếu mềm (yếu mềm)\r\nAnh muốn được vòng tay ra ôm em mỗi đêm\r\nLiệu anh có thể là người em chọn sánh đôi\r\nEm có muốn cùng anh đi qua bao bão giông\r\nCó muốn ở cạnh bên anh suốt đời\r\nMột thế giới riêng anh và em với những niềm vui hạnh phúc đắm say\r\nAnh muốn là người chở che khi em yếu mềm (yếu mềm)\r\nAnh muốn được vòng tay ra ôm em mỗi đêm\r\nLiệu anh có thể là người em chọn sánh đôi\r\nLiệu anh có thể là người sánh đôi"),
            new Music("Hai mươi hai", Resources.Hai_mươi_hai, "Acoustic", "Hứa Kim Tuyền", "AMEE, Hứa Kim Tuyền, Quanvrox", "Hai Mươi Hai (22) - AMEE x Hứa Kim Tuyền x Quanvrox「Lofi Version by 1 9 6 7」⧸ Audio Lyric Video.mp3", "Cuộc đời này là màu hồng\", mẹ nói lúc con ra đời\r\n\"Mỉm cười là điều tuyệt vời\", mẹ nói lúc con lên năm\r\nDù răng con sún, chân không dài, vai chẳng thon\r\nMặt Trời còn dẹt một phần mà sao thế gian luôn cần?\r\n\"Hãy làm điều mình tự hào\", mẹ nói lúc con lên 10\r\n\"Đừng làm điều mình ngần ngại\", mẹ nói lúc con 12\r\nDù cho đôi lúc con sai đường và quên lối đi\r\nTrưởng thành là điều tuyệt vời để từ sai ta học cho đúng\r\nSau này năm con hai mươi hai sẽ thấy màu mắt của con thật xinh\r\nThấy giọng ca ngân nga trong vắt có khi lại khiến con rất đặc biệt\r\nVà hãy nhớ, rằng trên đời này không ai phải giống ai\r\nNên là năm con hai mươi hai hãy sống hồn nhiên giống như mười hai\r\nTình đầu là điều tuyệt vời mà con khắc ghi suốt đời\r\nTừng chạm và từng dịu dàng làm tim của con rối bời\r\nĐừng quan tâm quá con sẽ cùng cậu ta đến đâu\r\nKỉ niệm là điều ở lại dù ai có đi xa mãi\r\nSau này năm con hai mươi hai sẽ thấy màu mắt của con thật xinh\r\nThấy giọng ca ngân nga trong vắt có khi lại khiến con rất đặc biệt\r\nVà hãy nhớ, rằng trên đời này không ai phải giống ai\r\nNên là năm con hai mươi hai hãy sống hồn nhiên giống như mười hai\r\nSau này năm con hai mươi hai hãy vang lời ca của con muôn nơi\r\nMang tình yêu thương con đang giữ nhân ra tỏa khắp muôn phương chân trời\r\nSẽ thật khó vì có đôi lần con sẽ cảm thấy chơi vơi\r\nNhưng chẳng sao khi con cho đi phía sau đừng nghĩ sẽ nhận lại gì\r\nNăm con hai mươi hai (ooh-ooh-ooh)\r\nNăm con hai mươi hai (ooh-wooh)\r\nSẽ thật khó vì có đôi lần con sẽ cảm thấy chơi vơi\r\nNhưng chẳng sao khi con cho đi phía sau đừng nghĩ sẽ nhận lại gì\r\nHai mươi hai\r\nHai mươi hai\r\nHai mươi hai\r\nHai mươi hai\r\nĐịa cầu là một hình tròn vậy nên thế gian xoay vòng\r\nĐiều mình nhận được là điều mình vô thức đã cho đi\r\nVậy nên sau nếu con có rời xa chốn đây\r\nĐừng sợ và đừng chần chừ vì đi cũng là để trở về\r\n"),
            new Music("Mặt trời khóc", Resources.Mặt_trời_khóc, "Acoustic", "Emcee L, Orange", "Emcee L, Orange", "Mặt Trời Khóc - Emcee L (Da LAB) ft Orange [Acoustic Version].mp3", "Bước đi thật nhanh anh chẳng có một điểm đến\r\nThành phố bỗng chốc như vụn vỡ là vì em\r\nDưới ánh hoàng hôn anh nhìn Mặt trời cũng khóc\r\nChỉ bởi vì nỗi đau ta đã cố mang cho nhau\r\nMất đi phương hướng anh lạc lõng giữa hành tinh này\r\nĐôi bàn tay tô lên giữa trời đêm hoang vu, những màu sắc em cho là cũ\r\nMột mặt trời từng là nguồn sáng cho em giờ lại rơi vào cảnh tối tăm\r\nOoh, ooh, ooh\r\nTâm tư em trào dâng cho tim anh như gợn sóng\r\nRồi chìm đắm cô đơn ngã giữa mùa đông\r\nAnh chợt thấy chơi vơi giữa trời đêm sao rơi khi nỗi nhớ em tìm tới\r\nBản nhạc khiến cho đôi ta dừng lại\r\nVà trái tim kia như ngừng đập\r\nVì chớp mắt em đã khiến những mộng mơ vụt mất\r\nBước đi thật nhanh anh chẳng có một điểm đến\r\nThành phố bỗng chốc như vụn vỡ là vì em\r\nDưới ánh hoàng hôn anh nhìn mặt trời cũng khóc\r\nChỉ bởi vì nỗi đau ta đã cố mang cho nhau\r\nTrái tim của em như đã vỡ tan từ lâu\r\nĐôi mắt nhắm rơi chìm đắm trong nỗi sầu\r\nRồi đến lúc mặt trời cũng rơi\r\nSẽ có nỗi đau vẫn mãi là của em\r\nAnh giật mình vội vàng bàng hoàng tỉnh giấc\r\nNhìn chiều tàn khi không có em là ngày buồn nhất\r\nBên thềm cỏ cây như xác xơ\r\nRơi rụng đầy trên những lá thư\r\nAnh lang thang dưới góc phố giữa mùa thu\r\nTừng ký ức chợt vội qua như đã cũ\r\nCó nỗi nhớ đem hạt mưa lặng lẽ rơi\r\nTình yêu là những lời sát thương em vô tình nói\r\nNếu biết trước ta chẳng ghé thăm nơi đây\r\nCho con tim một lần thôi những vấn vương về ai\r\nMặt trời khóc cho đến khi đêm về (đến khi đêm về)\r\nÔm nỗi đau nép vào màn đêm lặng lẽ\r\nCũng như hai ta\r\nChẳng ai vỗ về khi trái tim không còn muốn mạnh mẽ\r\nBước đi thật nhanh anh chẳng có một điểm đến\r\nThành phố bỗng chốc như vụn vỡ là vì em\r\nDưới ánh hoàng hôn anh nhìn mặt trời cũng khóc\r\nChỉ bởi vì nỗi đau ta đã cố mang cho nhau (ta đã cố, oh, oh)\r\nTrái tim của em như đã vỡ tan từ lâu (ta đã lỡ)\r\nĐôi mắt nhắm rơi chìm đắm trong nỗi sầu (ta đã cố, oh, oh)\r\nRồi đến lúc mặt trời cũng rơi\r\nSẽ có nỗi đau vẫn mãi là của em\r\nBước đi thật nhanh anh chẳng có một điểm đến\r\nThành phố bỗng chốc như vụn vỡ là vì em\r\nDưới ánh hoàng hôn anh nhìn mặt trời cũng khóc\r\nChỉ bởi vì nỗi đau ta đã cố mang cho nhau"),
            new Music("Say anh", Resources.Say_anh, "Acoustic", "Mỹ Mỹ, Dlow, VNIVERSE", "Mỹ Mỹ, Dlow", "SAY ANH＂ nhưng say nhẹ nhàng thôi - MỸ MỸ ｜ ACOUSTIC VERSION.mp3", "Hey boy\r\nBaby, baby, baby\r\nNếu chuyện tình mình là trăng sao baby\r\nEm sẽ nguyện được làm màn đêm đêm\r\nTiếng nhạc chẳng làm ta xôn xao baby\r\nChỉ muốn người mình cần cạnh bên bên\r\nGió mát đung đưa bên tai (êm) nghe nhẹ rung khẽ trái tim\r\nHai tay bên nhau trao nụ hôn mãi cho thật lâu\r\nMưa rơi không trôi chơi vơi chỉ thấy làm đẫm thêm trái tim\r\nSay heart two times cus i love you so\r\nGió mát bên tai êm nghe nhẹ rung khẽ trái tim\r\nHai tay bên nhau trao nụ hôn mãi\r\nMưa rơi chơi vơi không trôi chỉ thấy làm đẫm thêm trái tim\r\nSay heart two times cus I\r\nHôm nay em vẫn như mọi ngày\r\nVẫn có hương nước hoa nhẹ nhàng bay qua\r\nBóng dáng anh đâu đó đi qua chốn này\r\nĐể suy nghĩ trong mắt em vội vàng tiêu tan\r\nUống thêm một ly nào\r\nRót thêm một ly vào\r\nĐể cho đôi ta chìm đắm giữa muôn vì sao\r\nRót thêm một ly vào\r\nUống thêm một ly nào\r\nTrong cơn men say nồng mình đã biết yêu từ khi nào\r\nNếu chuyện tình mình là trăng sao baby\r\nEm sẽ nguyện được làm màn đêm đêm\r\nTiếng nhạc chẳng làm ta xôn xao baby\r\nChỉ muốn người mình cần cạnh bên bên\r\nTurn on, turn me on\r\nTake my heart and burn it on\r\nFrom the dusk till the dawn\r\nDo it right, don't do it wrong\r\nTrái tim em là công tắc, gặp anh là bật bật bật\r\nVà nếu anh đang đi tìm công chúa, thấy em là gật gật gật\r\nWe keep it lowkey, chẳng cần cho người ta xem\r\nYeah, em không muốn làm người ta ghen\r\nI believe in what i see, i believe that u're mah man\r\nEm chỉ cần đứng giữa 1000 người, thì anh vẫn tìm ra em\r\nIt's all about love\r\nBaby\r\nAnh đang thả rơi một nhịp ở trong nhà hát lộng lẫy và lấp lánh\r\nEm đến mời ta một điệu nhảy\r\nCứ thế cả hai cùng cất cánh\r\nBay giữa thiên hà\r\nMênh mông\r\nTay anh đang đặt ở bên hông\r\nCùng xoay một vòng đi theo âm nhạc để tâm trí vượt lên trên không\r\nNhững cảm xúc thăng hoa\r\nĐi theo dòng chảy rồi tan ra\r\nCó cả Hoa hồng và ánh nến\r\nNhiều điều thú vị cần khám phá\r\nMôi em đỏ hơn cả rượu vang\r\nMùi vị thân quen mà thượng hạng\r\nTrước mặt là cả một tuyệt tác\r\nYou know\r\nNếu chuyện tình mình là trăng sao baby\r\nEm sẽ nguyện được làm màn đêm đêm\r\nTiếng nhạc chẳng làm ta xôn xao baby\r\nChỉ muốn người mình cần cạnh bên bên\r\nGió mát bên tai êm nghe nhẹ rung khẽ trái tim\r\nHai tay bên nhau trao nụ hôn mãi\r\nMưa rơi chơi vơi không trôi chỉ thấy làm đẫm thêm trái tim\r\nSay heart two times cus I love you so\r\nGió mát bên tai êm nghe nhẹ rung khẽ trái tim\r\nHai tay bên nhau trao nụ hôn mãi\r\nMưa rơi chơi vơi không trôi chỉ thấy làm đẫm thêm trái tim\r\nSay heart two times cus I\r\nI know you are lonely baby\r\nSo do you want to take your time\r\nIf you are a beautiful song baby\r\nSo i will be your perfect rhythm"),
            new Music("Chuyện rằng", Resources.Chuyện_rằng, "Acoustic", "Thịnh Suy", "Thịnh Suy", "Thịnh Suy - CHUYỆN RẰNG (Official Music Video).mp3", "Lal lal lal hah\r\nKhi đêm ùa vào ôm chặt em\r\nOh I'm just a boy\r\nChẳng thể là quá muộn khi nói lời yêu một người\r\nChẳng thể là quá muộn khi ta hoài tiếc một đời\r\nNhững lời yêu sao quá khó khăn\r\nKìa những tháng năm dài ta đã cùng đi bên nhau\r\nNhìn đoá môi em cười cho ta một vết thương sâu\r\nNhững lời yêu sao quá khó khăn\r\nChuyện rằng huh huh huh huh mơ màng\r\nAnh giam yêu dấu trong anh từng phút yên lặng\r\nLà từng câu hát anh yêu em\r\nViết ra không tên\r\nKhi đêm đen về\r\nChuyện rằng năm tháng cứ trôi chẳng thấy quay lại\r\nTại sao anh vẫn đau khi nhìn thấy em bên ai\r\nLiệu rằng câu hát anh yêu em\r\nSẽ đến bên em khi đêm ùa vào ôm chặt em\r\nOh I'm just a boy\r\nTìm thấy nhau cả rồi nhưng trong lòng vẫn chơi vơi\r\nThả tiếng yêu không lời trôi theo ngọn gió muôn nơi\r\nNhững lời yêu sao quá khó khăn\r\nChuyện rằng huh huh huh huh mơ màng\r\nAnh giam yêu dấu trong anh từng phút yên lặng\r\nLà từng câu hát anh yêu em\r\nViết ra không tên\r\nKhi đêm đen về\r\nChuyện rằng năm tháng cứ trôi chẳng thấy quay lại\r\nTại sao anh vẫn đau khi nhìn thấy em bên ai\r\nLiệu rằng câu hát anh yêu em\r\nSẽ đến bên em\r\nKhi đêm ùa vào ôm chặt em\r\nNgập ngừng lời yêu la la love\r\nCó phải quá trễ để trao về em không la la love\r\nCó phải tiếng khóc cô đơn vì em la la love\r\nĐã đến lúc hát lên câu ca này\r\nNgập ngừng lời yêu la la love\r\nChẳng thể quá trễ để trao về em đâu la la love\r\nChẳng còn tiếng khóc cô đơn vì em la la love\r\nĐã đến lúc hát lên câu ca này\r\nChuyện rằng huh huh huh huh mơ màng\r\nAnh trao yêu dấu trong anh từng phút yên bình\r\nĐể từng câu hát anh yêu em\r\nSẽ đến bên em\r\nKhi đêm đen về\r\nChuyện rằng năm tháng cứ trôi chẳng thấy quay lại\r\nVà chẳng hối tiếc khi có nhìn thấy em bên ai\r\nĐể từng câu hát anh yêu em\r\nSẽ đến bên em\r\nKhi đêm ùa vào ôm chặt em\r\nOh I'm just a boy\r\n"),
            new Music("Bạn của tôi ơi", Resources.Bạn_của_tôi_ơi, "Acoustic", "Phạm Đình Thái Ngân", "Phạm Đình Thái Ngân", "BẠN CỦA TÔI ƠI ! PHẠM ĐÌNH THÁI NGÂN ｜ Love Memories Radio #3 [ MV LYRICS ].mp3", "Đã trải qua bao nhiêu kỷ niệm khó quên\r\nNhững năm tháng tươi đẹp giờ chia tay đã đến\r\nNhững vu vơ đem gửi lại trong giấc mơ\r\nBiết đâu lỡ mai này còn ai đang đợi chờ\r\nPre:\r\nMặc dù nhớ, rồi làm ngơ\r\nNhưng trong lòng vẫn hằng mong bên nhau xuân hạ thu đông\r\nTạm biệt nhé, goodbye\r\nLần này thôi được khóc để mai mình sẽ nhớ !\r\nChorus:\r\nBạn của tôi ơi hãy giữ mãi trong tim ký ức này\r\nĐể mai này lớn có cái để kể cho đàn con\r\nTa đã từng sống, từng mơ, từng cố gắng để trưởng thành hơn\r\nMột tuổi trẻ nhớ lại ta sẽ mỉm cười\r\nChào nhau lần cuối nước mắt cứ rơi không kịp nên lời\r\nGiọt thương lời nhớ men theo tiếng hát sâu vào tim\r\nBạn thân yêu hỡi hãy nhớ rằng\r\nCó tôi luôn bên cạnh\r\nBiết đâu trên đường đời mai gặp lại nhau\r\nĐã có những lúc ồn ào\r\nCùng nhau đàn ca nghêu ngao\r\nĐôi khi mình hát hơi phô cũng chẳng sao !\r\nƯớc muốn sẽ mãi vô tư\r\nChỉ bạn và tôi bên nhau\r\nThanh xuân này ta có nhau thật nhiệm màu"),
            new Music("Mây hạ", Resources.Mây_hạ, "Acoustic", "Starry Night", "Starry Night", "STARRY NIGHT - MÂY HẠ (OFFICIAL LYRIC VIDEO).mp3", "Em đi chiều nay đường nắng duỗi thân dài\r\nChân chưa vội lay lại đau từng bước mọn\r\nEm ca bài ca chiều nay buồn hơn khóc\r\nNghe từng ngày mai thẫn thờ một mình đây\r\nTrời chiều nay mây buông thành khói\r\nBóng anh sẽ mờ còn đâu em nhớ\r\nNgày dìm em khuất trong màn sương\r\nMờ ảnh cuối đường vàng võ niềm thương\r\nEm lên tàu đây sầu kín suốt toa dài\r\nTay ôm niềm đau còn tay nào giấu mặt\r\nKhóc cũng đành thôi thời gian làm sao nắm\r\nThương từng hoàng hôn mây về chở sầu theo\r\nTrời chiều nay mây buông thành khói\r\nBóng anh sẽ mờ còn đâu em nhớ\r\nNgày dìm em khuất trong màn sương\r\nMờ ảnh cuối đường vàng võ niềm thương\r\nEm lên tàu đây sầu kín suốt toa dài\r\nTay ôm niềm đau còn tay nào giấu mặt\r\nKhóc cũng đành thôi thời gian làm sao nắm\r\nThương từng hoàng hôn mây về chở sầu theo\r\nEm mãi còn đi sầu giăng dầy đêm tối\r\nThương từ ngoài hiên dấu hài chìm vào mưa"),
            new Music("Khi em lớn", Resources.Khi_em_lớn, "Acoustic", "Orange", "Orange, Hoàng Dũng", "Orange x Hoàng Dũng - ‘Khi Em Lớn’ Official MV.mp3", "Verse 1:\r\n\r\nKhi em lớn\r\nVui biết bao vì được đi muôn nơi\r\nKhông phải đi về nhà trước 10 giờ tối Hmm… em lớn rồi mà\r\nKhi em lớn\r\nTrước mắt em là bầu trời trong xanh\r\nEm cứ vô tư chạy đi thật nhanh\r\nNào có biết rằng\r\nNgày em lớn\r\n\r\nChorus:\r\n\r\nEm sẽ ngã đau hơn bây giờ\r\nĐời đâu giống đôi vần thơ\r\nEm nhận ra thế gian\r\nAi cũng làm ngơ\r\nKhóc với ai bây giờ\r\nVì sẽ chẳng có ai lắng nghe\r\nĐiều không có ai muốn nghe\r\nEm lặng thinh…\r\nHuhuhuhuhuhuhu x3\r\n\r\nVerse 2:\r\n\r\nKhi em lớn\r\nSẽ có lúc em nhận ra em yêu\r\nXây biết bao hy vọng đến người em ước sau này\r\nSẽ về một nhà\r\n\r\nKhi em lớn\r\nSẽ có hơn đôi lần mà em trao\r\nSẽ có hơn đôi lần mà em tin\r\nNào có biết rằng\r\nNgày em lớn\r\n\r\nChorus:\r\n\r\nEm lại lỡ tin sai một người\r\nLời gian dối trên vành môi\r\nEm nhận ra trái tim em\r\nVỡ làm đôi\r\nKhóc với ai bây giờ\r\nVì sẽ chẳng có ai lắng nghe\r\nĐiều không có ai muốn nghe\r\nEm lặng thinh Huhuhuhuhuhu x3\r\n\r\nBridge:\r\n\r\nKhi em lớn đường về nhà sao quá xa\r\nCha mẹ đây nhưng sao thật khó để nói ra\r\nCon thất bại rồi\r\nChỉ muốn bé lại thôi\r\nEm à…\r\n\r\nChorus:\r\n\r\nEm sẽ ngã thêm đôi ba lần\r\nSẽ xây xước đôi bàn chân\r\nNhưng rồi em sẽ quen thôi chớ ngại ngần\r\nDẫu em có một mình\r\nChỉ cần em vẫn luôn lắng nghe\r\nĐiều không có ai lắng nghe\r\nHuhuhuhuhuhu x6"),
            new Music("Vì em có anh", Resources.Vì_em_có_anh, "Acoustic", "Hoàng Yến Chibi", "Hoàng Yến Chibi", "Vì Em Có Anh ｜ Hoàng Yến Chibi ｜ Stay home with Hoang Yen Chibi (1).mp3", "Ngày xưa, ngày ta ngày đầu mới quen\r\nMột hai, vài câu rồi không nhớ tên\r\nVà ta chụp chung một bức hình\r\nAnh post lên ngay sau khi gặp\r\nNgày ta hẹn nhau lần đầu với nhau\r\nLà em chọn đi cùng anh tới nơi\r\nMà em luôn muốn thấy được hoàng hôn\r\nNếu lỡ mai này ta cách xa\r\nVẫn nhớ những ngày tháng đã qua\r\nEm luôn ở đây để mong được anh nhắc mỗi ngày\r\nVì em có anh, em rạng ngời\r\nMình cùng đi xa và bên nhau hát ca\r\nDù nhiều lúc em hay làm anh thấy buồn\r\nAnh vẫn luôn bên em và nói\r\nChuyện tình chúng ta, ai nào ngờ\r\nTự nhiên hôm đi đường lại va lấy nhau\r\nVà giờ anh không tìm được ai nữa như vậy\r\nLuôn muốn bên anh luôn ân cần\r\nVì em có anh, em rạng ngời\r\nDù là hôm nay, là ngày mai, vẫn có anh\r\nVì em rất yêu anh và không muốn xa rời\r\nEm muốn anh bên em và nói\r\nTừng ngày chúng ta bên nhau lặng thầm\r\nVà ngày hôm nay, ngày anh muốn lấy em\r\nChẳng còn cách xa nhau và hai trái tim gần\r\nEm muốn anh bên em ân cần\r\nLuôn muốn anh bên em ân cần\r\nChỉ mỗi anh yêu em trăm lần\r\n"),
            new Music("Thương", Resources.Thương, "Acoustic", "Tiến Nguyễn", "Reddy", "Thương (Acoustic Version) - Reddy ｜ Music ATM #23 NEW VERSION.mp3", "Mưa vừa ghé qua rằng: \"Mưa vừa ôm em đấy\"\r\nGió phiêu du tìm tóc em và tìm bờ môi phai\r\nGhen với gió, giận cơn mưa, mong cho trời đứng lại\r\nGiật nụ hôn từ gió khát, làm trời cao để ôm mưa\r\nĐi kiếm nắng, tận mây xa, mong cho lòng ấm lại\r\nĐể còn yêu mùa gió mới, để còn say tình chênh vênh\r\nHát vu vơ về mây, về mưa, tình em giờ đây giữ riêng mình\r\nMúa vi vu ngàn câu, ngàn ca vì nhớ ban mai\r\nTính sao đây tình em, dòng sông giờ như mùa xuân úa phai màu\r\nVẫn như ta đành thương, đành vương, đành nhớ thế thôi\r\nGhen với gió, giận cơn mưa, mong cho trời đứng lại\r\nGiật nụ hôn từ gió khát, làm trời cao để ôm mưa\r\nĐi kiếm nắng, tận mây xa, mong cho lòng ấm lại\r\nĐể còn yêu mùa gió mới, để còn say tình chênh vênh\r\nThương\r\nHát vu vơ về mây, về mưa, tình em giờ đây giữ riêng mình\r\nMúa vi vu ngàn câu, ngàn ca vì nhớ ban mai\r\nTính sao đây tình em, dòng sông giờ như mùa xuân úa phai màu\r\nVẫn như ta đành thương, đành vương, đành nhớ thế thôi\r\nGhen với gió, giận cơn mưa, mong cho trời đứng lại\r\nGiật nụ hôn từ gió khát, làm trời cao để ôm mưa\r\nĐi kiếm nắng, tận mây xa, mong cho lòng ấm lại\r\nĐể còn yêu mùa gió mới, để còn say tình chênh vênh\r\nThương"),
        };
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            btn_Home.ForeColor = Color.White;
            btn_History.ForeColor = Color.Black;
          
            btn_DM.ForeColor = Color.Black;
            btn_Love.ForeColor = Color.Black;
            btn_Playlist.ForeColor = Color.Black;
    
            Home uc = new Home(music, btn_Home.Text);
            addUserControl(uc);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //btn_Search.ForeColor = Color.White;
            btn_Home.ForeColor = Color.Black;
            btn_History.ForeColor = Color.Black;

            btn_Love.ForeColor = Color.Black;
            btn_Playlist.ForeColor = Color.Black;
            btn_DM.ForeColor = Color.Black;
            Home uc = new Home(music, btn_Home.Text);
            addUserControl(uc);
        }

        private void btn_Playlist_Click(object sender, EventArgs e)
        {
            btn_Home.ForeColor = Color.Black;
            btn_History.ForeColor = Color.Black;
           // btn_Search.ForeColor = Color.Black;
            btn_Love.ForeColor = Color.Black;
            btn_Playlist.ForeColor = Color.White;
            btn_DM.ForeColor = Color.Black;
            user_playlist uc = new user_playlist();
            addUserControl(uc);
        }

        private void btn_Love_Click(object sender, EventArgs e)
        {
            btn_Home.ForeColor = Color.Black;
            btn_History.ForeColor = Color.Black;
           // btn_Search.ForeColor = Color.Black;
            btn_DM.ForeColor = Color.Black;
            btn_Love.ForeColor = Color.White;
            btn_Playlist.ForeColor = Color.Black;

            Home uc = new Home(love_music, btn_Love.Text);
            addUserControl(uc);
        }


        private void btn_History_Click(object sender, EventArgs e)
        {
            btn_DM.ForeColor = Color.Black;
            btn_Home.ForeColor = Color.Black;
            btn_History.ForeColor = Color.White;
          //  btn_Search.ForeColor = Color.Black;
            
            btn_Love.ForeColor = Color.Black;
            btn_Playlist.ForeColor = Color.Black;

            Home uc = new Home(music, btn_History.Text);
            addUserControl(uc);
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure about that?", "QUIT?",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(0);
            }
        }

        private void _Acoustic_Click(object sender, EventArgs e)
        {
            btn_Home.ForeColor = Color.Black;
            btn_History.ForeColor = Color.Black;
           // btn_Search.ForeColor = Color.Black;
            btn_DM.ForeColor = Color.Black;
            btn_Love.ForeColor = Color.Black;
            btn_Playlist.ForeColor = Color.Black;
            _Indie.ForeColor = Color.Black;
            _Acoustic.ForeColor = Color.White;
            _NKL.ForeColor = Color.Black;
            Home uc = new Home(music, _Acoustic.Text);
            addUserControl(uc);
        }

        private void _Indie_Click(object sender, EventArgs e)
        {
            btn_Home.ForeColor = Color.Black;
            btn_History.ForeColor = Color.Black;
           // btn_Search.ForeColor = Color.Black;
            btn_DM.ForeColor = Color.Black;
            btn_Love.ForeColor = Color.Black;
            btn_Playlist.ForeColor = Color.Black;
            _Indie.ForeColor = Color.White;
            _Acoustic.ForeColor = Color.Black;
            _NKL.ForeColor = Color.Black;
            Home uc = new Home(music, _Indie.Text);
            addUserControl(uc);
        }

        private void _NKL_Click(object sender, EventArgs e)
        {
            btn_Home.ForeColor = Color.Black;
            btn_History.ForeColor = Color.Black;
            //btn_Search.ForeColor = Color.Black;
            btn_DM.ForeColor = Color.Black;
            btn_Love.ForeColor = Color.Black;
            btn_Playlist.ForeColor = Color.Black;
            _Indie.ForeColor = Color.Black;
            _Acoustic.ForeColor = Color.Black;
            _NKL.ForeColor = Color.White;
            Home uc = new Home(music, _NKL.Text);
            addUserControl(uc);
        }

        private void btn_DM_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.SendToBack();
            panel2.BringToFront();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
            panel1.BringToFront();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.SelectAll();
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    btn_Home.ForeColor = Color.Black;
                    btn_History.ForeColor = Color.Black;
                  //  btn_Search.ForeColor = Color.Black;
                    btn_DM.ForeColor = Color.Black;
                    btn_Love.ForeColor = Color.Black;
                    btn_Playlist.ForeColor = Color.Black;
                    find_user uc = new find_user(music, textBox1.Text);
                    addUserControl(uc);
                }
            }
        }

        internal void load_musicc()
        {

        }
    }
}
