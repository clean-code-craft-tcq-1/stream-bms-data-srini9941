package bms.stream.sender.value.fetcher;

import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-03
 */
public class ValueFetcherFactory {

    private List<ValueFetcher> valueFetchers = Stream.of(
        new TemperatureValueFetcher(),
        new SOCValueFetcher()
    ).collect(Collectors.toList());

    public ValueFetcher getValueFetcherFor(String name) {
        return valueFetchers.stream()
            .filter(i -> i.getClass().getName().toLowerCase().contains(name))
            .findFirst()
            .orElse(null);
    }
}
