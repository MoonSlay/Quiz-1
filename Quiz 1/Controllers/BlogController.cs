using Microsoft.AspNetCore.Mvc;
using Quiz_1.Models;

namespace Quiz_1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index(int year, int month, string slug)
        {
            var blogmodel = new BlogModel();

            if (slug == "Animals")
            {
                blogmodel.Title = "Animals";
                blogmodel.Sub = "My Top 3 Favorite Animals";
                blogmodel.BgImage = "~/img/Animals/animal.png";
                blogmodel.Image1 = "~/img/Animals/Dog.png";
                blogmodel.Image2 = "~/img/Animals/cat.png";
                blogmodel.Image3 = "~/img/Animals/fish.png";
                blogmodel.Name1 = "DOG";
                // <strong></strong> = bold, <br> = next line, <ul>/<li> = bullet. make sure to use @Html.Raw
                blogmodel.Desc1 = 
                    "<strong>Breed Type:</strong> Australian Shepherd " +
                    "<br> " +
                    "<strong>Temperament:</strong>" +
                    "<ul>" +
                    "<li>Australian Shepherds, often referred to as \"Aussies,\" are known for their intelligence and high energy levels.</li>" +
                    "<li>They are loyal, affectionate, and have a strong herding instinct.</li>" +
                    "</ul>" +
                    "<strong>Physical Characteristics:</strong>" +
                    "<ul>" +
                    "<li>Aussies are medium-sized dogs with a well-balanced and agile build.</li>" +
                    "<li>Their eyes are a striking feature, often coming in blue, brown, or even one of each.</li>" +
                    "</ul>" +
                    "<strong>Health Considerations:</strong>Overall, Australian Shepherds are a healthy breed, but they can be prone to certain genetic conditions like hip dysplasia and eye issues.";
                blogmodel.Name2 = "CAT";
                blogmodel.Desc2 = "<strong>Breed Type:</strong> Persian Cat " +
                    "<br> " +
                    "<strong>Temperament:</strong> " +
                    "<ul> " +
                    "<li>Persian cats are known for their calm and gentle demeanor.</li> " +
                    "<li>They are affectionate and enjoy a relaxed lifestyle, making them excellent indoor companions.</li> " +
                    "</ul> " +
                    "<strong>Physical Characteristics:</strong> " +
                    "<ul> " +
                    "<li>Persians have a distinctive appearance with a round face, short nose, and large, expressive eyes.</li> " +
                    "<li>Their long, luxurious coat comes in a variety of colors and patterns.</li> " +
                    "</ul> " +
                    "<strong>Health Considerations:</strong> Persian cats may be prone to certain health issues, including respiratory and dental problems due to their facial structure.";
                blogmodel.Name3 = "FISH";
                blogmodel.Desc3 = "<strong>Species: </strong> Koi fish are a colorful and ornamental variety of the common carp (Cyprinus Carpio). " +
                    "<br> " +
                    "<strong>Temperament:</strong> " +
                    "<ul> " +
                    "<li>Koi fish are known for their docile and social nature.</li> " +
                    "<li>They can recognize their owners and often swim up to them during feeding times.</li> " +
                    "</ul> " +
                    "<strong>Physical Characteristics:</strong> " +
                    "<ul> " +
                    "<li>Koi have a sleek and streamlined body, similar to common carp, with flowing fins and barbels (whisker-like sensory organs near the mouth).</li> " +
                    "</ul> " +
                    "<strong>Health Considerations:</strong> Proper pond maintenance, water quality monitoring, and regular health checks are essential for the well-being of Koi.";
            }
            else if (slug == "Anime")
            {
                blogmodel.Title = "Anime";
                blogmodel.Sub = "My Top 3 Favorite Anime";
                blogmodel.BgImage = "~/img/Anime/anime.png";
                blogmodel.Image1 = "~/img/Anime/mushoku.png";
                blogmodel.Image2 = "~/img/Anime/Nisekoi.png";
                blogmodel.Image3 = "~/img/Anime/onepunch.png";
                blogmodel.Name1 = "Mushoku Tensei(Jobless Reincarnation)";
                blogmodel.Desc1 = "<strong>Genre: </strong>Fantasy, Isekai, Adventure " +
                    "<br> " +
                    "<strong>Key Characters:</strong> " +
                    "<ul> " +
                    "<li><strong>Rudeus Greyrat (Rudy): </strong>The protagonist, a former recluse who is reborn in a fantasy world with memories of his past life intact. </li> " +
                    "<li><strong>Roxy Migurdia:  </strong>Rudy's first mentor, a talented water mage who teaches him the basics of magic. </li> " +
                    "<li><strong>Sylphiette (Sylphy):  </strong>Rudy's childhood friend and later romantic interest, a beast-girl with wolf-like characteristics.</li> " +
                    "<li><strong>Eris Boreas Greyrat: </strong>Rudy's second cousin, a skilled swordswoman, and one of his traveling companions.</li> " +
                    "</ul> " +
                    "<strong>Themes:</strong> " +
                    "<ul> " +
                    "<li><strong>Reincarnation and Redemption: </strong>Rudy, having been given a second chance in life, seeks redemption and self-improvement.</li> " +
                    "<li><strong>Magic and Adventure: </strong>The series explores the intricate magic system of the fantasy world and follows Rudy's journey as he hones his magical abilities.</li> " +
                    "<li><strong>Fantasy World Lore: </strong>The anime delves into the lore and history of the fantasy world, creating a rich backdrop for the story.</li> " +
                    "</ul> ";
                blogmodel.Name2 = "Nisekoi";
                blogmodel.Desc2 = "<strong>Genre: </strong>Fantasy, Isekai, Adventure " +
                    "<br> " +
                    "<strong>Key Characters:</strong> " +
                    "<ul> " +
                    "<li><strong>Raku Ichijou: </strong>The main protagonist, a high school student and heir to the yakuza faction. He becomes entangled in a fake relationship to maintain peace between rival factions.</li> " +
                    "<li><strong>Chitoge Kirisaki: </strong>The female lead, a vivacious and energetic high school girl. She pretends to be in a relationship with Raku to prevent gang conflict.</li> " +
                    "<li><strong>Kosaki Onodera: </strong>Raku's classmate and a girl with a gentle demeanor. She harbors a secret crush on Raku.</li> " +
                    "</ul> " +
                    "<strong>Themes:</strong> " +
                    "<ul> " +
                    "<li><strong>Fake Relationships: </strong>The central plot revolves around Raku and Chitoge pretending to be in a relationship to maintain peace between their respective factions.</li> " +
                    "<li><strong>High School Romance: </strong>Nisekoi explores the classic themes of high school romance, friendship, and the challenges of adolescence.</li> " +
                    "<li><strong>Love Rivalries: </strong>The story introduces various love interests for Raku, leading to comedic and heartfelt moments as romantic tensions unfold.</li> " +
                    "</ul> ";
                blogmodel.Name3 = "One Punch Man";
                blogmodel.Desc3 = "<strong>Genre: </strong>Action, Comedy, Superhero" +
                    "<br> " +
                    "<strong>Key Characters:</strong> " +
                    "<ul> " +
                    "<li><strong>Saitama (One Punch Man): </strong>The protagonist, a hero who can defeat any opponent with a single punch. Despite his incredible strength, he struggles with boredom and the lack of challenging foes.</li> " +
                    "<li><strong>Genos: </strong>Saitama's loyal disciple and a powerful cyborg hero. He seeks revenge against the mysterious cyborg that destroyed his hometown.</li> " +
                    "</ul> " +
                    "<strong>Themes:</strong> " +
                    "<ul> " +
                    "<li><strong>Humor and Action: </strong>The series combines intense, well-animated action sequences with humor, creating a unique blend that appeals to a wide audience.</li> " +
                    "<li><strong>Hero Association: </strong>The organized system that classifies heroes into different ranks based on their abilities and achievements.</li> " +
                    "<li><strong>Existential Crisis: </strong>Saitama's struggle with the lack of challenging opponents and the monotony of his superhero life.</li> " +
                    "</ul> ";

            }
            else if (slug == "Dota 2")
            {
                blogmodel.Title = "Dota 2";
                blogmodel.Sub = "My Top 3 Favorite Hero";
                blogmodel.BgImage = "~/img/Dota2/dota2.png";
                blogmodel.Image1 = "~/img/Dota2/phantom.png";
                blogmodel.Image2 = "~/img/Dota2/slardar.png";
                blogmodel.Image3 = "~/img/Dota2/sniper.png";
                blogmodel.Name1 = "PHANTOM ASSASIN <br>  ( The Elusive Assassin)";
                blogmodel.Desc1 = "<strong>Role: </strong>Melee/Damage Dealer" +
                    "<br> " +
                    "<strong>Abilities:</strong> " +
                    "<ul> " +
                    "<li><strong>Stifling Dagger (Q): </strong>PA throws a dagger at a target, slowing and dealing damage.</li> " +
                    "<li><strong>Phantom Strike (W): </strong>Allows PA to blink to a target and increases attack speed for a short duration.</li> " +
                    "<li><strong>Blur (E): </strong>Grants evasion, making PA harder to hit, especially against physical attacks.</li> " +
                    "<li><strong>Coup de Grace (R): </strong>PA's critical strike ability, providing a chance to deal massive damage.</li> " +
                    "</ul> " +
                    "<strong>Ideal Lane: </strong> Midlane/Safelane " +
                    "<br> " +
                    "<strong>Common Items: </strong> " +
                    "<ul> " +
                    "<li><strong>Battle Fury: </strong> Farming efficiency and cleave damage</li> " +
                    "<li><strong>Desolator: </strong>Armor reduction</li> " +
                    "<li><strong>Black King Bar: </strong>Spell immunity</li>" +
                    "</ul> ";
                blogmodel.Name2 = "SLARDAR <br>  ( Slithereen Guard )";
                blogmodel.Desc2 = "<strong>Role: </strong>Melee Tank/Initiator" +
                    "<br> " +
                    "<strong>Abilities:</strong> " +
                    "<ul> " +
                    "<li><strong>Sprint (Q): </strong>Slardar Increases his movement speed at the cost of some HP.</li> " +
                    "<li><strong>Slithereen Crush (W): </strong>Slardar Damages and stuns nearby enemies.</li> " +
                    "<li><strong>Bash of the Deep (E): </strong>Slardar Stuns Every fourth attack</li> " +
                    "<li><strong>Corrosive Haze (R): </strong>Slardar Reducing armor of targeted enemies and show location.</li> " +
                    "</ul> " +
                    "<strong>Ideal Lane: </strong>Offlane " +
                    "<br> " +
                    "<strong>Common Items: </strong> " +
                    "<ul> " +
                    "<li><strong>Blink dagger: </strong>Initiation</li> " +
                    "<li><strong>Assault Cuirass: </strong>Attack speed and reduce enemy armor</li> " +
                    "<li><strong>Black King Bar: </strong>Spell immunity</li>" +
                    "</ul> ";
                blogmodel.Name3 = "SNIPER <br>  ( The Sharpshooter)";
                blogmodel.Desc3 = "<strong>Role: </strong>Range/Damage Dealer" +
                    "<br> " +
                    "<strong>Abilities:</strong> " +
                    "<ul> " +
                    "<li><strong>Shrapnel (Q): </strong>Sniper deploys an area-of-effect slowing and damaging ability.</li> " +
                    "<li><strong>Headshot (W): </strong>Sniper's attacks have a chance to slow and deal bonus damage.</li> " +
                    "<li><strong>Take Aim (E): </strong>Increases Sniper's attack range, allowing him to attack enemies from a safer distance.</li> " +
                    "<li><strong>Assassinate (R): </strong>Sniper locks onto an enemy, channeling to deliver a high-damage shot from a long range.</li> " +
                    "</ul> " +
                    "<strong>Ideal Lane: </strong>Midlane/Safelane" +
                    "<br> " +
                    "<strong>Common Items: </strong> " +
                    "<ul> " +
                    "<li><strong>Mjollnir: </strong>Increased damage and lightning procs</li> " +
                    "<li><strong>Satanic: </strong>Sustain</li> " +
                    "<li><strong>Hurricane Pike: </strong>Mobility and Positioning</li>" +
                    "</ul> ";
            }
            else if (slug == "League of Legends")
            {
                blogmodel.Title = "League of Legends";
                blogmodel.Sub = "My Top 3 Favorite Champion";
                blogmodel.BgImage = "~/img/LOL/lol.png";
                blogmodel.Image1 = "~/img/LOL/jhin.png";
                blogmodel.Image2 = "~/img/LOL/kayn.png";
                blogmodel.Image3 = "~/img/LOL/trundle.png";
                blogmodel.Name1 = "JHIN <br> (Virtuoso)";
                blogmodel.Desc1 = "<strong>Role: </strong>Marksman/ADC (Attack Damage Carry)" +
                    "<br> " +
                    "<strong>Abilities:</strong> " +
                    "<ul> " +
                    "<li><strong>Dancing Grenade (Q): </strong>Bouncing grenade damaging and marking enemies.</li> " +
                    "<li><strong>Captivate (W): </strong>Long-range snare that slows, damages, and roots.</li> " +
                    "<li><strong>Deadly Flourish (E): </strong>Skillshot revealing and rooting enemies.</li> " +
                    "<li><strong>Curtain Call (R): </strong>Global high-damage shots, with the last shot dealing massive damage and slowing.</li> " +
                    "</ul> " +
                    "<strong>Ideal Lane: </strong>Bot Lane (Bottom Carry/ADC) " +
                    "<br> " +
                    "<strong>Common Items: </strong> " +
                    "<ul> " +
                    "<li><strong>Rapid Firecannon: </strong>Extends attack range.</li> " +
                    "<li><strong>Infinity Edge: </strong>Amplifies critical strikes.</li> " +
                    "<li><strong>Collector: </strong>Boosts finishing power.</li>" +
                    "</ul> ";
                blogmodel.Name2 = "KAYN <br>  (The Shadow Reaper)";
                blogmodel.Desc2 = "<strong>Role: </strong>Assassin/Fighter" +
                    "<br> " +
                    "<strong>Abilities:</strong> " +
                    "<ul> " +
                    "<li><strong>Reaping Slash (Q): </strong>Slashes enemies in a line, dealing damage and granting Kayn bonus movement speed.</li> " +
                    "<li><strong>Blade's Reach (W): </strong>Throws a blade that damages and slows enemies.</li> " +
                    "<li><strong>Shadow Step (E): </strong>Navigates through terrain, providing increased movement speed.</li> " +
                    "<li><strong>Umbral Trespass (R): </strong>Becomes untargetable and dashes through an enemy, dealing damage.</li> " +
                    "</ul> " +
                    "<strong>Ideal Lane: </strong>Jungle" +
                    "<br> " +
                    "<strong>Common Items: </strong> " +
                    "<ul> " +
                    "<li><strong>Edge of Night: </strong>survivability.</li> " +
                    "<li><strong>Youmuu's Ghostblade: </strong>Mobility and lethality.</li> " +
                    "<li><strong>Goredrinker: </strong>Sustain and Damage.</li>" +
                    "</ul> ";
                blogmodel.Name3 = "TRUNDLE <br>  (The Troll King)";
                blogmodel.Desc3 = "<strong>Role: </strong>Fighter/Jungler" +
                    "<br> " +
                    "<strong>Abilities:</strong> " +
                    "<ul> " +
                    "<li><strong>Chomp (Q): </strong>Empowers Trundle's next basic attack, dealing bonus damage and stealing attack damage.</li> " +
                    "<li><strong>Frozen Domain (W): </strong>Creates an area that increases Trundle's attack speed, movement speed, and healing.</li> " +
                    "<li><strong>Pillar of Ice (E): </strong>Summons a pillar at a target location, slowing and displacing enemies in its radius.</li> " +
                    "<li><strong>Subjugate (R): </strong>Drains health and steals resistances from the target, making Trundle tankier.</li> " +
                    "</ul> " +
                    "<strong>Ideal Lane: </strong>Jungler/Top Lane " +
                    "<br> " +
                    "<strong>Common Items: </strong> " +
                    "<ul> " +
                    "<li><strong>Titanic Hydra: </strong>Adds bonus damage and health, improving wave clear.</li> " +
                    "<li><strong>Sterak's Gage: </strong>Boosts survivability and provides a shield in team fights.</li> " +
                    "<li><strong>Spirit Visage: </strong>Increases healing from Trundle's abilities.</li>" +
                    "</ul> ";
            }
            else if (slug == "Manga")
            {
                blogmodel.Title = "Manga";
                blogmodel.Sub = "My Top 3 Favorite Manga";
                blogmodel.BgImage = "~/img/Manga/manga.png";
                blogmodel.Image1 = "~/img/Manga/mounthua.png";
                blogmodel.Image2 = "~/img/Manga/sololevel.png";
                blogmodel.Image3 = "~/img/Manga/Tales.png";
                blogmodel.Name1 = "RETURN OF MOUNT HUA SECT";
                blogmodel.Desc1 = "<strong>Genre: </strong>Action, Martial Arts, Drama" +
                    "<br> " +
                    "<strong>Key Characters:</strong> " +
                    "<ul> " +
                    "<li><strong>Cheongmyeong: </strong>The protagonist, a skilled martial artist seeking to revive the fallen Mount Hua Sect.</li> " +
                    "<li><strong>Yoo Iseol: </strong>Cheongmyeong’s ally, a talented fighter with a mysterious past.\r\n</li> " +
                    "</ul> " +
                    "<strong>Themes:</strong> " +
                    "<ul> " +
                    "<li><strong>Revival and Redemption: </strong>The manga delves into Cheongmyeong’s journey of reviving the glory of Mount Hua Sect amidst numerous challenges.</li> " +
                    "<li><strong>Conflict and Confrontation: </strong>Central to the narrative are intense battles and confrontations that test the characters’ skills and resolve.</li> " +
                    "<li><strong>Alliances and Enmities: </strong>Relationships, both new and old, shape the course of events as alliances are forged and enmities resurface.</li> " +
                    "</ul> ";
                blogmodel.Name2 = "SOLO LEVELING";
                blogmodel.Desc2 = "<strong>Genre: </strong>Action, Fantasy, Adventure" +
                    "<br> " +
                    "<strong>Key Characters:</strong> " +
                    "<ul> " +
                    "<li><strong>Sung Jin-Woo: </strong>The protagonist, initially an E-rank Hunter, who becomes entangled in a mysterious system that transforms his life.</li> " +
                    "<li><strong>Cha Hae-In: </strong>A powerful S-rank Hunter and member of the Korean Hunters Association, she becomes a crucial ally to Sung Jin-Woo.</li> " +
                    "</ul> " +
                    "<strong>Themes:</strong> " +
                    "<ul> " +
                    "<li><strong>Leveling System: </strong>The manga revolves around a unique leveling system that grants individuals special powers, with Sung Jin-Woo's journey of growth and power accumulation at the center.</li> " +
                    "<li><strong>Monsters and Dungeons: </strong>Rich with battles against formidable monsters and exploration of mysterious dungeons.</li> " +
                    "<li><strong>Guilds and Associations: </strong>Sung Jin-Woo navigates the complex world of Hunter guilds and alliances.</li> " +
                    "</ul> ";
                blogmodel.Name3 = "TALES OF DEMONS AND GODS";
                blogmodel.Desc3 = "<strong>Genre: </strong>Fantasy, Martial Arts, Adventure" +
                    "<br> " +
                    "<strong>Key Characters:</strong> " +
                    "<ul> " +
                    "<li><strong>Nie Li: </strong>The protagonist, a talented demon spiritualist, and the central figure in rewriting his destiny.</li> " +
                    "<li><strong>Ye Ziyun: </strong>Nie Li's love interest, a skilled spiritualist with her own challenges and goals.</li> " +
                    "</ul> " +
                    "<strong>Themes:</strong> " +
                    "<ul> " +
                    "<li><strong>Cultivation: </strong>The series explores the cultivation of spiritual energy, martial arts, and the pursuit of strength.</li> " +
                    "<li><strong>Reincarnation and Time Travel: </strong>Nie Li's knowledge from his past life shapes his decisions, adding a unique element to the storyline.</li> " +
                    "<li><strong>Friendship and Betrayal: </strong>Relationships and alliances play a crucial role, with themes of trust and betrayal woven into the narrative.</li> " +
                    "</ul> ";
            }
            else
            {
                blogmodel.Title = "Valorant";
                blogmodel.Sub = "My Top 3 Favorite Agents";
                blogmodel.BgImage = "~/img/Valorant/valorant.png";
                blogmodel.Image1 = "~/img/Valorant/REYNA.png";
                blogmodel.Image2 = "~/img/Valorant/CHAMBER.png";
                blogmodel.Image3 = "~/img/Valorant/brimstone.png";
                blogmodel.Name1 = "REYNA";
                blogmodel.Desc1 = "<strong>Role: </strong>Duelist" +
                    "<br> " +
                    "<strong>Abilities:</strong> " +
                    "<ul> " +
                    "<li><strong>Leer (C): </strong>Sends out an ethereal eye that, when activated, nearsights all looking at it.</li> " +
                    "<li><strong>Devour (Q): </strong>Consumes the soul orb of a killed enemy to rapidly heal and gain a combat stim.</li> " +
                    "<li><strong>Dismiss (E): </strong>Allows Reyna to teleport a short distance in the direction she's moving.</li> " +
                    "<li><strong>Empress (X - Ultimate): </strong>Empowers Reyna, increasing her fire rate, making her invulnerable, and enhancing her healing and devour abilities.</li> " +
                    "</ul> " +
                    "<strong>Playstyle: </strong>Aggressive Entry Fragger.";
                blogmodel.Name2 = "CHAMBER";
                blogmodel.Desc2 = "<strong>Role: </strong>Initiator" +
                    "<br> " +
                    "<strong>Abilities:</strong> " +
                    "<ul> " +
                    "<li><strong>Trademark (C): </strong>Deploys a signature device that marks enemies, revealing their location for a short duration.</li> " +
                    "<li><strong>Rendezvous (Q): </strong>Creates a portal that allows Chamber to quickly traverse the battlefield.</li> " +
                    "<li><strong>Precision (E): </strong>Enhances Chamber’s weapon accuracy, reducing recoil and increasing fire rate for a limited time.</li> " +
                    "<li><strong>Mastermind (X - Ultimate): </strong>Grants vision over the entire map, revealing enemy positions and their movements for a brief period.</li> " +
                    "</ul> " +
                    "<strong>Playstyle: </strong>Strategic Map Control.";
                blogmodel.Name3 = "BRIMSTONE";
                blogmodel.Desc3 = "<strong>Role: </strong>Initiator/Controller" +
                    "<br> " +
                    "<strong>Abilities:</strong> " +
                    "<ul> " +
                    "<li><strong>Incendiary (C): </strong>Throws an incendiary grenade that deals damage over time to enemies in its area of effect.</li> " +
                    "<li><strong>Stim Beacon (Q): </strong>Deploys a stimulant beacon that grants a fire rate and reload speed bonus.</li> " +
                    "<li><strong>Sky Smoke (E): </strong>Calls in orbital smokescreens at targeted locations, providing cover for teammates.</li> " +
                    "<li><strong>Orbital Strike (X - Ultimate): </strong>Launches a laser strike at a designated location, dealing massive damage over time.</li> " +
                    "</ul> " +
                    "<strong>Playstyle: </strong>Tactical Leader";
            }
            return View(blogmodel);
        }

    }
}
