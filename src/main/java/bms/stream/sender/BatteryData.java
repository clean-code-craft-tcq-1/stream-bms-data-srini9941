package bms.stream.sender;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-04
 */
public class BatteryData {

    private Double temperature;
    private Double soc;

    public BatteryData(
        double temperature,
        double soc
    )
    {
        this.temperature = temperature;
        this.soc = soc;
    }

    @Override
    public String toString() {
        return "BatteryData{\n" +
            "\ttemperature:" + temperature + ", \n" +
            "\tsoc:" + soc + ", \n" +
            '}';
    }
}
