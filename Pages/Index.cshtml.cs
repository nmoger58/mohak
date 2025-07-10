using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string? SelectedBrand { get; set; }

    [BindProperty]
    public string? SelectedModel { get; set; }

    public string? Description { get; set; }

    public Dictionary<string, Dictionary<string, string>> CarData = new()
    {
        ["Aston Martin"] = new()
        {
            ["DB11"] = "The Aston Martin DB11 is a grand touring masterpiece that blends handcrafted luxury with potent V12 performance. It features a 5.2-liter twin-turbocharged V12 engine producing around 630 horsepower, enabling 0–60 mph acceleration in just 3.7 seconds. The DB11 delivers a refined yet thrilling driving experience with an adaptive damping system and a sophisticated 8-speed automatic gearbox. Inside, you'll find high-end materials, a customizable leather interior, and modern infotainment wrapped in British elegance — making it as enjoyable on long drives as it is on curvy roads.",
            ["Vantage"] = "The Aston Martin Vantage is a compact and powerful sports car known for its sleek lines and razor-sharp handling. It’s equipped with a 4.0-liter twin-turbo V8 engine producing 503 horsepower and 685 Nm of torque, accelerating from 0–60 mph in about 3.6 seconds. The Vantage features active aerodynamics, adaptive suspension, and a rear-mounted transaxle for perfect balance. Its interior combines premium Alcantara, customizable leather trim, and a driver-focused layout. Mileage: ~20 MPG. Engine: 3982 cc. Price: Starts around $150,000."
        },
        ["BMW"] = new()
        {
            ["M3"] = "The BMW M3 is a motorsport-inspired high-performance sedan combining comfort, precision, and raw power. It boasts a 3.0-liter twin-turbocharged inline-6 engine pushing 473 horsepower (503 hp in Competition trim) and 650 Nm of torque. It can sprint from 0–60 mph in just 3.8 seconds with the Competition xDrive. With adaptive M suspension, sport exhaust, and a fully digital cockpit, the M3 delivers thrilling dynamics without compromising daily comfort. Mileage: ~19 MPG. Engine: 2993 cc. Price: Starts around $75,000.",
            ["i8"] = "The BMW i8 is a plug-in hybrid sports coupe that merges performance with futuristic design. Its combination of a turbocharged 1.5-liter 3-cylinder engine and an electric motor delivers 369 horsepower and 0–60 mph in 4.2 seconds. Constructed with carbon fiber and aluminum, the i8 offers aerodynamic efficiency and electric-only driving for short trips. Inside, the cabin includes floating displays, unique scissor doors, and eco-friendly materials. Mileage: ~69 MPGe. Engine: 1499 cc (gas) + electric. Price: Around $147,500."
        },
        ["Mercedes-Benz"] = new()
        {
            ["C-Class"] = "The Mercedes-Benz C-Class is a compact luxury sedan offering refinement, safety, and innovation. Powered by a 2.0-liter turbocharged inline-4 engine producing 255 horsepower and 400 Nm of torque, it provides responsive acceleration and smooth handling. Inside, the cabin features dual digital displays, leatherette trim, ambient lighting, and the MBUX infotainment system with voice assistant. The ride is quiet and composed, with features like adaptive cruise control and parking assist. Mileage: ~26 MPG combined. Engine: 1991 cc. Price: Starts around $46,000.",
            ["AMG GT"] = "The Mercedes-AMG GT is a sleek, front-mid-engine performance coupe designed for track-capable performance and style. It’s powered by a handcrafted 4.0-liter twin-turbo V8 that produces up to 577 horsepower and 700 Nm of torque. It can launch from 0–60 mph in just 3.5 seconds and features an active rear spoiler, dynamic engine mounts, and a dual-clutch transaxle. The cabin features race-style seats, digital displays, and AMG performance controls. Mileage: ~18 MPG. Engine: 3982 cc. Price: Starts around $118,000."
        },
        ["Audi"] = new()
        {
            ["A4"] = "The Audi A4 is a luxury compact sedan known for its balance of performance, technology, and comfort. It offers a turbocharged 2.0-liter 4-cylinder engine with 261 horsepower and Audi's quattro all-wheel drive, ensuring great grip and composure in all weather. The refined cabin includes a 10.1-inch touchscreen, virtual cockpit, tri-zone climate control, and premium materials. It’s quiet, efficient, and enjoyable to drive daily. Mileage: ~27 MPG combined. Engine: 1984 cc. Price: Starts around $44,000.",
            ["R8"] = "The Audi R8 is a naturally aspirated V10 supercar that shares DNA with the Lamborghini Huracán. Its 5.2-liter V10 delivers up to 602 horsepower and 560 Nm of torque, rocketing it from 0–60 mph in just 3.2 seconds. With Audi’s quattro AWD system, carbon ceramic brakes, and magnetic ride suspension, the R8 offers everyday usability with track-level performance. The low, wide stance and premium cockpit complete the experience. Mileage: ~15 MPG. Engine: 5204 cc. Price: Starts around $160,000."
        },
        ["Lamborghini"] = new()
        {
            ["Huracan"] = "The Lamborghini Huracán is a mid-engine supercar powered by a 5.2-liter naturally aspirated V10 engine producing 630 horsepower and 600 Nm of torque. It delivers brutal acceleration — 0–60 mph in just 2.9 seconds — and precise cornering with available AWD and a lightweight chassis. Its dramatic design features Y-shaped LED lights, a sharp rear diffuser, and a fighter-jet inspired cockpit. It’s one of the most visceral and exhilarating driving experiences available. Mileage: ~15 MPG. Engine: 5204 cc. Price: Starts at $240,000.",
            ["Urus"] = "The Lamborghini Urus is a super SUV combining sports car dynamics with everyday practicality. Powered by a 4.0-liter twin-turbo V8 producing 657 horsepower and 850 Nm of torque, it rockets from 0–60 mph in just 3.5 seconds. It offers multiple drive modes (including off-road), adaptive air suspension, and all-wheel steering. The luxurious interior seats five, with Alcantara, carbon fiber, and touchscreen controls. Mileage: ~14 MPG. Engine: 3996 cc. Price: Starts at $235,000"
        },
        ["Ferrari"] = new()
        {
            ["488 GTB"] = "The Ferrari 488 GTB is a turbocharged mid-engine supercar known for its power, agility, and classic Ferrari styling. Its 3.9-liter twin-turbo V8 produces 661 horsepower and 760 Nm of torque, accelerating from 0–60 mph in 3.0 seconds. The car features active aerodynamics, side slip angle control, and a 7-speed dual-clutch gearbox. Inside, the cockpit is driver-centric with performance-focused displays. Mileage: ~18 MPG. Engine: 3902 cc. Price: Starts around $280,000.",
            ["Roma"] = "The Ferrari Roma is a stylish grand touring coupe with timeless design and modern performance. It has a 3.9-liter twin-turbo V8 producing 612 horsepower and 760 Nm of torque, paired with an 8-speed dual-clutch gearbox. The Roma goes from 0–60 mph in 3.4 seconds and offers a refined yet sporty ride. The interior is minimalist yet high-tech, featuring touch-sensitive controls and leather surfaces. Mileage: ~19 MPG. Engine: 3855 cc. Price: Starts at $225,000"
        },
        ["Porsche"] = new()
        {
            ["911"] = "The Porsche 911 is a rear-engine sports car icon, combining timeless design with evolving technology and performance. Its 3.0-liter twin-turbo flat-six engine produces between 379–640 horsepower depending on variant, delivering sharp throttle response and signature handling. It features rear- or all-wheel drive, a PDK dual-clutch transmission, and optional rear-axle steering. The cabin is a blend of analog tradition and digital innovation. Mileage: ~20–22 MPG. Engine: 2981 cc. Price: Starts at $116,000..",
            ["Taycan"] = "The Porsche Taycan is a fully electric sports sedan delivering exhilarating performance with zero emissions. It offers dual motors, up to 750 horsepower in Turbo S trim, and an innovative 800V architecture for rapid charging. 0–60 mph takes as little as 2.6 seconds. With a luxury interior featuring four digital displays, leather-free options, and adaptive air suspension, it balances speed with sophistication. Range: ~246 miles. Price: Starts at $88,000"
        },
        ["Tesla"] = new()
        {
            ["Model S"] = "The Tesla Model S is a luxury electric sedan that redefined EV performance. The tri-motor Plaid variant produces over 1,000 horsepower, enabling 0–60 mph in under 2 seconds — making it one of the quickest production cars ever. It offers up to 405 miles of range, full self-driving capability (optional), and a spacious cabin with a 17-inch touchscreen, yoke steering, and premium audio. Mileage: ~120 MPGe. Price: Starts around $75,000; Plaid ~ $90,000.",
            ["Cybertruck"] = "The Tesla Cybertruck is a revolutionary all-electric pickup featuring a futuristic design and durable exoskeleton made from cold-rolled stainless steel. It offers up to 800 horsepower in tri-motor form, towing capacity over 14,000 lbs, and 0–60 mph in 2.9 seconds. The cabin seats six, with a 17-inch display and adaptive air suspension. Designed for work and play, the Cybertruck blends utility with sports car performance. Range: Up to 340 miles. Price: Starts around $60,000"
        },
        ["Toyota"] = new()
        {
            ["Camry"] = "The Toyota Camry is a best-selling midsize sedan praised for reliability, safety, and efficiency. It offers a 2.5-liter 4-cylinder or a 3.5-liter V6 producing up to 301 horsepower, with smooth 8-speed automatic transmission and available AWD. The interior is roomy and refined with touchscreen infotainment, driver assists, and available hybrid version offering up to 52 MPG. Engine: 2487–3456 cc. Price: Starts around $27,000.",
            ["Supra"] = "The Toyota GR Supra is a performance coupe co-developed with BMW, combining Japanese styling with German engineering. It’s powered by a 3.0-liter turbo inline-6 with 382 horsepower and 500 Nm torque, reaching 0–60 mph in 3.9 seconds. With a 50:50 weight distribution, adaptive suspension, and limited-slip differential, it delivers sharp, agile handling. Mileage: ~26 MPG. Engine: 2998 cc. Price: Starts at $46,000."
        },
        ["Nissan"] = new()
        {
            ["GT-R"] = "The Nissan GT-R (R35) is a legendary AWD performance coupe nicknamed 'Godzilla' for its monstrous acceleration and road grip. It uses a 3.8-liter twin-turbo V6 engine delivering up to 600 horsepower (NISMO), paired with a 6-speed dual-clutch transmission. It sprints from 0–60 mph in 2.9 seconds and features launch control, torque vectoring, and a track-tuned suspension. Mileage: ~18 MPG. Engine: 3799 cc. Price: Starts around $115,000.",
            ["370Z"] = "The Nissan 370Z is a classic rear-wheel-drive coupe offering accessible performance and simple fun. Powered by a 3.7-liter V6 producing 332 horsepower, it offers crisp handling, a short-throw manual gearbox, and a lightweight chassis. The styling is timeless with a long hood and compact tail, while the interior remains focused on the driver. Mileage: ~20 MPG. Engine: 3696 cc. Price: Starts around $32,000"
        }
    };

    public void OnPost()
    {
        if (!string.IsNullOrEmpty(SelectedBrand) &&
            !string.IsNullOrEmpty(SelectedModel) &&
            CarData.ContainsKey(SelectedBrand) &&
            CarData[SelectedBrand].ContainsKey(SelectedModel))
        {
            Description = CarData[SelectedBrand][SelectedModel];
        }
        else
        {
            Description = "No description available for this model.";
        }
    }
}
