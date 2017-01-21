using System.Xml.Schema;
using NUnit.Framework;

public class KinderGartenGardenTest
{
    [Test]
    public void Missing_child()
    {
        var actual = Garden.DefaultGarden("RC\nGG").GetPlantsForStudent("Potter");
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Alice()
    {
        Assert.That(Garden.DefaultGarden("RC\nGG").GetPlantsForStudent("Alice"), Is.EqualTo(new [] { Plant.Radishes, Plant.Clover, Plant.Grass, Plant.Grass }));
        Assert.That(Garden.DefaultGarden("VC\nRC").GetPlantsForStudent("Alice"), Is.EqualTo(new[] { Plant.Violets, Plant.Clover, Plant.Radishes, Plant.Clover }));
    }

    [Test]
    public void Small_garden()
    {
        var actual = Garden.DefaultGarden("VVCG\nVVRC").GetPlantsForStudent("Bob");
        Assert.That(actual, Is.EqualTo(new[] { Plant.Clover, Plant.Grass, Plant.Radishes, Plant.Clover }));
    }

    [Test]
    public void Medium_garden()
    {
        var garden = Garden.DefaultGarden("VVCCGG\nVVCCGG");
        Assert.That(garden.GetPlantsForStudent("Bob"), Is.EqualTo(new[] { Plant.Clover, Plant.Clover, Plant.Clover, Plant.Clover }));
        Assert.That(garden.GetPlantsForStudent("Charlie"), Is.EqualTo(new[] { Plant.Grass, Plant.Grass, Plant.Grass, Plant.Grass }));
    }

    [Test]
    public void Full_garden()
    {
        var garden = Garden.DefaultGarden("VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV");
        Assert.That(garden.GetPlantsForStudent("Alice"), Is.EqualTo(new[] { Plant.Violets, Plant.Radishes, Plant.Violets, Plant.Radishes }));
        Assert.That(garden.GetPlantsForStudent("Bob"), Is.EqualTo(new[] { Plant.Clover, Plant.Grass, Plant.Clover, Plant.Clover }));
        Assert.That(garden.GetPlantsForStudent("David"), Is.EqualTo(new[] { Plant.Radishes, Plant.Violets, Plant.Clover, Plant.Radishes }));
        Assert.That(garden.GetPlantsForStudent("Eve"), Is.EqualTo(new[] { Plant.Clover, Plant.Grass, Plant.Radishes, Plant.Grass }));
        Assert.That(garden.GetPlantsForStudent("Fred"), Is.EqualTo(new[] { Plant.Grass, Plant.Clover, Plant.Violets, Plant.Clover }));
        Assert.That(garden.GetPlantsForStudent("Ginny"), Is.EqualTo(new[] { Plant.Clover, Plant.Grass, Plant.Grass, Plant.Clover }));
        Assert.That(garden.GetPlantsForStudent("Harriet"), Is.EqualTo(new[] { Plant.Violets, Plant.Radishes, Plant.Radishes, Plant.Violets }));
        Assert.That(garden.GetPlantsForStudent("Ileana"), Is.EqualTo(new[] { Plant.Grass, Plant.Clover, Plant.Violets, Plant.Clover }));
        Assert.That(garden.GetPlantsForStudent("Joseph"), Is.EqualTo(new[] { Plant.Violets, Plant.Clover, Plant.Violets, Plant.Grass }));
        Assert.That(garden.GetPlantsForStudent("Kincaid"), Is.EqualTo(new[] { Plant.Grass, Plant.Clover, Plant.Clover, Plant.Grass }));
        Assert.That(garden.GetPlantsForStudent("Larry"), Is.EqualTo(new[] { Plant.Grass, Plant.Violets, Plant.Clover, Plant.Violets }));
    }

    [Test]
    public void Surprise_garden()
    {
        var garden = new Garden(new [] { "Samantha", "Patricia", "Xander", "Roger" }, "VCRRGVRG\nRVGCCGCV");
        Assert.That(garden.GetPlantsForStudent("Patricia"), Is.EqualTo(new[] { Plant.Violets, Plant.Clover, Plant.Radishes, Plant.Violets }));
        Assert.That(garden.GetPlantsForStudent("Roger"), Is.EqualTo(new[] { Plant.Radishes, Plant.Radishes, Plant.Grass, Plant.Clover }));
        Assert.That(garden.GetPlantsForStudent("Samantha"), Is.EqualTo(new[] { Plant.Grass, Plant.Violets, Plant.Clover, Plant.Grass }));
        Assert.That(garden.GetPlantsForStudent("Xander"), Is.EqualTo(new[] { Plant.Radishes, Plant.Grass, Plant.Clover, Plant.Violets }));
    }
}